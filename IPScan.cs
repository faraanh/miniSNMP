using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using NetUtils;
using System.Net;
using System.Collections;
//using System.Net.NetworkInformation.NetworkInterface;
using System.Net.NetworkInformation;

namespace minisnmp
{
    public partial class IPScan : Form
    {
        private IPScanner _scanner;
        private class HostSorterByIP : IComparer
        {
            public int Compare(object x, object y)
            {
                byte[] bytes1 = ((IPScanHostState)((ListViewItem)x).Tag).Address.GetAddressBytes();
                byte[] bytes2 = ((IPScanHostState)((ListViewItem)y).Tag).Address.GetAddressBytes();
                int i = bytes1.Length - 1;
                for (; i > 0 && bytes1[i] == bytes2[i]; i--);
                return bytes1[i] - bytes2[i];
            }
        }

        public IPScan()
        {
            InitializeComponent();
            _scanner = new IPScanner((int)_spnConcurrentPings.Value, (int)_spnPingsPerScan.Value, false,
                (int)_spnTimeout.Value, (int)_spnTTL.Value, false, (int)_spnBufferSize.Value);
            _scanner.OnAliveHostFound += new IPScanner.AliveHostFoundDelegate(_scanner_OnAliveHostFound);
            _scanner.OnStartScan += new IPScanner.ScanStateChangeDelegate(_scanner_OnStartScan);
            _scanner.OnStopScan += new IPScanner.ScanStateChangeDelegate(_scanner_OnStopScan);
            _scanner.OnRestartScan += new IPScanner.ScanStateChangeDelegate(_scanner_OnRestartScan);
            _scanner.OnScanProgressUpdate += new IPScanner.ScanProgressUpdateDelegate(_scanner_OnScanProgressUpdate);
            _lvAliveHosts.ListViewItemSorter = new HostSorterByIP();
            _cmbRangeType.SelectedIndex = 0;
        }

        private void _scanner_OnAliveHostFound(IPScanner scanner, IPScanHostState host)
        {
            if (InvokeRequired)
            {
                BeginInvoke(new IPScanner.AliveHostFoundDelegate(_scanner_OnAliveHostFound), scanner, host);
                return;
            }

            ListViewItem item = new ListViewItem();
            item.Tag = host;
            item.BackColor = Color.GreenYellow;
            item.SubItems.Add(host.Address.ToString());
            item.SubItems.Add("");
            item.SubItems.Add("");
            item.SubItems.Add("");
            item.SubItems.Add("");
            _lvAliveHosts.Items.Add(item);
            _lvAliveHosts.Sort();
            host.OnHostNameAvailable += new IPScanHostState.HostNameAvailableDelegate(host_OnHostNameAvailable);
            host.OnStateChange += new IPScanHostState.StateChangeDelegate(host_OnStateChange);
            if (!host.IsTesting())
            {
                item.ImageIndex = (int)host.QualityCategory;
                item.SubItems[2].Text = host.AvgResponseTime.ToString("F02") + " ms";
                item.SubItems[3].Text = ((float)(host.LossCount) / host.PingsCount).ToString("P");
                item.SubItems[4].Text = host.HostName;
                item.SubItems[5].Text = GetMacAddress(host.Address.ToString()).ToUpper();
            }

            AddLogEntry("Host [" + host.Address.ToString() + "] is running.");
            Timer newTimer = new Timer();
            newTimer.Tag = item;
            newTimer.Interval = 2000;
            newTimer.Tick += new EventHandler(newTimer_Tick);
            newTimer.Enabled = true;
        }

        void host_OnHostNameAvailable(IPScanHostState host)
        {
            if (InvokeRequired)
            {
                BeginInvoke(new IPScanHostState.HostNameAvailableDelegate(host_OnHostNameAvailable), host);
                return;
            }

            ListViewItem item = FindListViewItem(host);
            if (item != null)
                item.SubItems[4].Text = host.HostName;
        }

        void newTimer_Tick(object sender, EventArgs e)
        {
            Timer timer = (Timer)sender;

            timer.Stop();
            timer.Tick -= newTimer_Tick;

            ListViewItem item = (ListViewItem)timer.Tag;
            item.BackColor = Color.White;
        }

        private void host_OnStateChange(IPScanHostState host, IPScanHostState.State oldState)
        {
            if (InvokeRequired)
            {
                BeginInvoke(new IPScanHostState.StateChangeDelegate(host_OnStateChange), host, oldState);
                return;
            }

            if (!host.IsTesting())
            {
                ListViewItem item = FindListViewItem(host);
                if (item != null)
                {
                    if (host.IsAlive())
                    {
                        item.ImageIndex = (int)host.QualityCategory;
                        item.SubItems[2].Text = host.AvgResponseTime.ToString("F02") + " ms";
                        item.SubItems[3].Text = ((float)(host.LossCount) / host.PingsCount).ToString("P");
                    }
                    else
                    {
                        AddLogEntry("Host [" + host.Address.ToString() + "] died.");

                        host.OnStateChange -= host_OnStateChange;
                        host.OnHostNameAvailable -= host_OnHostNameAvailable;

                        item.BackColor = Color.IndianRed;

                        Timer removeTimer = new Timer();
                        removeTimer.Tag = item;
                        removeTimer.Interval = 2000;
                        removeTimer.Tick += new EventHandler(removeTimer_Tick);

                        removeTimer.Enabled = true;
                    }
                }
            }
        }

        void removeTimer_Tick(object sender, EventArgs e)
        {
            Timer timer = (Timer)sender;
            timer.Stop();
            timer.Tick -= newTimer_Tick;
            ListViewItem item = (ListViewItem)timer.Tag;
            _lvAliveHosts.Items.Remove(item);
        }

        private ListViewItem FindListViewItem(IPScanHostState host)
        {
            foreach (ListViewItem item in _lvAliveHosts.Items)
            {
                if (item.Tag == host)
                    return item;
            }
            return null;
        }

        private void EnableSettings(bool enable)
        {
            _cmbRangeType.Enabled = _tbRangeStart.Enabled = _tbRangeEnd.Enabled = _spnTimeout.Enabled = _spnTTL.Enabled = _spnBufferSize.Enabled =
                _spnConcurrentPings.Enabled = _spnPingsPerScan.Enabled  = enable;
            _btnStartStop.Text = enable ? "&ReScan_IP" : "&Stop";
            if (enable)
                _prgScanProgress.Text = "Quét Ip không hoạt động!";
        }

        private void AddLogEntry(string message)
        {
            _lbLog.Items.Add(DateTime.Now.ToString("[HH:mm:ss]: ") + message);
            _lbLog.TopIndex = _lbLog.Items.Count - _lbLog.Height / _lbLog.ItemHeight;
        }

        private void _scanner_OnStopScan(IPScanner scanner)
        {
            if (InvokeRequired)
            {
                BeginInvoke(new IPScanner.ScanStateChangeDelegate(_scanner_OnStopScan), scanner);
                return;
            }
            EnableSettings(true);

            AddLogEntry("Finished Scanning!");
            AddLogEntry("Hosts found: " + _scanner.AliveHosts.Count);
            _prgScanProgress.Value = 0;
        }

        private void _scanner_OnStartScan(IPScanner scanner)
        {
            if (InvokeRequired)
            {
                BeginInvoke(new IPScanner.ScanStateChangeDelegate(_scanner_OnStartScan), scanner);
                return;
            }

            foreach (ListViewItem item in _lvAliveHosts.Items)
            {
                ((IPScanHostState)item.Tag).OnStateChange -= host_OnStateChange;
                ((IPScanHostState)item.Tag).OnHostNameAvailable -= host_OnHostNameAvailable;
            }
            _lvAliveHosts.Items.Clear();
            _lbLog.Items.Clear();
            AddLogEntry("Start scanning!");
            _prgScanProgress.Value = 0;
            EnableSettings(false);
        }

        void _scanner_OnRestartScan(IPScanner scanner)
        {
            if (InvokeRequired)
            {
                BeginInvoke(new IPScanner.ScanStateChangeDelegate(_scanner_OnRestartScan), scanner);
                return;
            }

            AddLogEntry("Scaned!");
            AddLogEntry("Hosts found : " + _scanner.AliveHosts.Count);
            AddLogEntry("Rescan!");
            _prgScanProgress.Value = 0;
        }

        void _scanner_OnScanProgressUpdate(IPScanner scanner, IPAddress currentAddress, ulong progress, ulong total)
        {
            if (InvokeRequired)
            {
                BeginInvoke(new IPScanner.ScanProgressUpdateDelegate(_scanner_OnScanProgressUpdate), scanner, currentAddress, progress, total);
                return;
            }

            int prog = (int)((100 * progress) / total);
            _prgScanProgress.Value = prog;
            _prgScanProgress.Text = prog.ToString() + "%" + " [" + currentAddress.ToString() + "]";
        }

        private void _cmbRangeType_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (_cmbRangeType.SelectedIndex == 0)
            {
                _lRangeSep.Text = "-";
                _lRangeEnd.Text = "IP end:";
                _tbRangeEnd.Size = new Size(130, _tbRangeEnd.Size.Height);
            }
            else
            {
                _lRangeSep.Text = "/";
                _lRangeEnd.Text = "Subnet &Mask:";
                _tbRangeEnd.Size = new Size(32, _tbRangeEnd.Size.Height);
            }
        }

        private void _spnTimeout_ValueChanged(object sender, EventArgs e) { _scanner.Timeout = (int)_spnTimeout.Value; }
        private void _spnTTL_ValueChanged(object sender, EventArgs e) { _scanner.TTL = (int)_spnTTL.Value; }
        private void _spnBufferSize_ValueChanged(object sender, EventArgs e) { _scanner.PingBufferSize = (int)_spnBufferSize.Value; }
        private void _spnConcurrentPings_ValueChanged(object sender, EventArgs e) { _scanner.ConcurrentPings = (int)_spnConcurrentPings.Value; }
        private void _spnPingsPerScan_ValueChanged(object sender, EventArgs e) { _scanner.PingsPerScan = (int)_spnPingsPerScan.Value; }
        public string GetMacAddress(string ipAddress)
        {
            string macAddress = string.Empty;
            System.Diagnostics.Process pProcess = new System.Diagnostics.Process();
            pProcess.StartInfo.FileName = "arp";
            pProcess.StartInfo.Arguments = "-a " + ipAddress;
            pProcess.StartInfo.UseShellExecute = false;
            pProcess.StartInfo.RedirectStandardOutput = true;
            pProcess.StartInfo.CreateNoWindow = true;
            pProcess.Start();
            string strOutput = pProcess.StandardOutput.ReadToEnd();
            string[] substrings = strOutput.Split('-');
            if (substrings.Length >= 8)
            {
                macAddress = substrings[3].Substring(Math.Max(0, substrings[3].Length - 2))
                         + "-" + substrings[4] + "-" + substrings[5] + "-" + substrings[6]
                         + "-" + substrings[7] + "-"
                         + substrings[8].Substring(0, 2);
                return macAddress;
            }
            else
            {
                return "Not found";
            }
        }

        private void _btnStartStop_Click(object sender, EventArgs e)
        {
            if (!_scanner.Active)
            {
                try
                {
                    _scanner.Start(_cmbRangeType.SelectedIndex == 0
                        ? new IPScanRange(IPAddress.Parse(_tbRangeStart.Text), IPAddress.Parse(_tbRangeEnd.Text))
                        : new IPScanRange(IPAddress.Parse(_tbRangeStart.Text), int.Parse(_tbRangeEnd.Text)));
                }
                catch (FormatException)
                {
                    MessageBox.Show(this, "Your IP rang or subnet mask have problems!", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
                _scanner.Stop(false);
        }
        private void IPScanForm_FormClosing(object sender, FormClosingEventArgs e) { _scanner.Stop(true); }
        private ListViewItem.ListViewSubItem _activeTooltipSubitem = null;
        private static string[] QualityCategoryNames = { "Very Poor", "Poor", "Fair", "Good", "Very Good", "Excellent", "Perfect" };
        private void _lvAliveHosts_MouseMove(object sender, MouseEventArgs e)
        {
            ListViewItem item = _lvAliveHosts.HitTest(e.Location).Item;
            if (item != null)
            {
                ListViewItem.ListViewSubItem subitem = _lvAliveHosts.HitTest(e.Location).SubItem;
                if (subitem != null && item.SubItems.IndexOf(subitem) == 0)
                {
                    if (_activeTooltipSubitem != subitem)
                    {
                        _ttQuality.Show("Quality: " + QualityCategoryNames[item.ImageIndex], _lvAliveHosts, item.SubItems[1].Bounds.X, subitem.Bounds.Y);
                        _activeTooltipSubitem = subitem;
                    }
                    return;
                }
            }
            _activeTooltipSubitem = null;
            _ttQuality.Hide(_lvAliveHosts);
        }

        private void _lvAliveHosts_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void _spnTimeout_ValueChanged_1(object sender, EventArgs e)
        {

        }

        private void _lbLog_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void toolTip1_Popup(object sender, PopupEventArgs e)
        {
            
        }

        public static IPAddress GetDefaultGateway()
        {
            IPAddress result = null;
            var cards = NetworkInterface.GetAllNetworkInterfaces().ToList();
            if (cards.Any())
            {
                foreach (var card in cards)
                {
                    var props = card.GetIPProperties();
                    if (props == null)
                        continue;
                    var gateways = props.GatewayAddresses;
                    if (!gateways.Any())
                        continue;
                    var gateway =
                        gateways.FirstOrDefault(g => g.Address.AddressFamily.ToString() == "InterNetwork");
                    if (gateway == null)
                        continue;
                    result = gateway.Address;
                    break;
                };
            }
            return result;
            //return NetworkInterface.GetAllNetworkInterfaces().Where(n => n.OperationalStatus == OperationalStatus.Up).SelectMany(n => n.GetIPProperties()?.GatewayAddresses).Select(g => g?.Address).FirstOrDefault(a => a != null);
        }

        private void IPScan_Load(object sender, EventArgs e)
        {
            string hostName = Dns.GetHostName(); // Retrive the Name of HOST
            textBox2.Text += "Local host: "+hostName;
            // Get the IP
            string myIP = Dns.GetHostEntry(hostName).AddressList[0].ToString();
            textBox2.Text +="\r\n\t IP:"+ myIP;
            // Default gateway
            textBox2.Text +="\r\n\t default gateway: "+ GetDefaultGateway();
            foreach (NetworkInterface f in NetworkInterface.GetAllNetworkInterfaces())
            {
                textBox2.Text += "\r\n" + f.Name;
                IPInterfaceProperties ipInterface = f.GetIPProperties();
                foreach (UnicastIPAddressInformation unicastAddress in ipInterface.UnicastAddresses)
                {
                    textBox2.Text+= unicastAddress.IPv4Mask == null ? "\r\n\t" + "No subnet defined" : "\r\n\t" + unicastAddress.IPv4Mask.ToString();
                }
            }
            /// Scan immediatetly!
            if (!_scanner.Active)
            {
                try
                {
                    _scanner.Start(new IPScanRange( GetDefaultGateway() , 24 ));
                }
                catch (FormatException)
                {
                    MessageBox.Show(this, "Can't auto scan", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
                _scanner.Stop(false);
        }

        private void _lRangeEnd_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void iPScanToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            SNMP snmp = new SNMP();
            snmp.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Chương trình Demo sử dụng giao thức SMNP\nGiáo viên hướng dẫn:\n\t Thầy Đại úy Ths.Đỗ Đặng Việt Khoa\nNhóm 1 lớp B4D4:\n\tĐoàn Đắc Ngọc Anh\n\tVõ Tấn Hậu\n\tVũ Anh Hùng\n\tHoàng Ngọc Việt\n\tNguyễn Văn Tuyên", "About", MessageBoxButtons.OK);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MJSniff.HelpF helpf = new MJSniff.HelpF();
            helpf.Show();
        }
    }
}
