using System;
using System.Windows.Forms;
using SnmpSharpNet;
using System.Net;


namespace minisnmp
{
    public partial class SNMP : Form
    {
        int dong = 1;
        public SNMP()
        {
            InitializeComponent();
        }

        private void GetOne(int n, RichTextBox rtb)
        {
            n++;
            // SNMP community name
            OctetString community = new OctetString(txtConStr.Text);

            // Define agent parameters class
            AgentParameters param = new AgentParameters(community);
            // Set SNMP version to 1 (or 2)
            param.Version = SnmpVersion.Ver1;
            // Construct the agent address object
            // IpAddress class is easy to use here because
            //  it will try to resolve constructor parameter if it doesn't
            //  parse to an IP address
            try
            {
                IpAddress agent = new IpAddress(txtIPAgent.Text);

                // Construct target
                UdpTarget target = new UdpTarget((IPAddress)agent, 161, 2000, 1);

                // Pdu class used for all requests
                Pdu pdu = new Pdu(PduType.Get);
                pdu.VbList.Add("1.3.6.1.2.1.2.2.1.2." + n.ToString()); //ifDescr
                pdu.VbList.Add("1.3.6.1.2.1.2.2.1.3." + n.ToString()); //ifType
                pdu.VbList.Add("1.3.6.1.2.1.2.2.1.5." + n.ToString()); //ifSpeed
                pdu.VbList.Add("1.3.6.1.2.1.2.2.1.6." + n.ToString()); //ifPhysAddress
                pdu.VbList.Add("1.3.6.1.2.1.2.2.1.7." + n.ToString()); //ifAdminStatus
                pdu.VbList.Add("1.3.6.1.2.1.2.2.1.8." + n.ToString()); //ifOperStatus
                // Make SNMP request
                SnmpV1Packet result = (SnmpV1Packet)target.Request(pdu, param);

                // If result is null then agent didn't reply or we couldn't parse the reply.
                if (result != null)
                {
                    // ErrorStatus other then 0 is an error returned by 
                    // the Agent - see SnmpConstants for error definitions
                    if (result.Pdu.ErrorStatus != 0)
                    {
                        // agent reported an error with the request

                        rtb.Text = "Error in SNMP reply. Error " + result.Pdu.ErrorStatus + " index " + result.Pdu.ErrorIndex;
                    }
                    else
                    {
                        // Reply variables are returned in the same order as they were added to the VbList
                        rtb.Text = "ifDescr(" + result.Pdu.VbList[0].Oid.ToString() + ") (" + SnmpConstants.GetTypeName(result.Pdu.VbList[0].Value.Type) + "): " + "\n\t" + result.Pdu.VbList[0].Value.ToString();
                        rtb.Text = rtb.Text + "\n" + "ifType(" + result.Pdu.VbList[1].Oid.ToString() + ") (" + SnmpConstants.GetTypeName(result.Pdu.VbList[1].Value.Type) + "): " + "\n\t" + GetType(int.Parse(result.Pdu.VbList[1].Value.ToString()));
                        rtb.Text = rtb.Text + "\n" + "ifSpeed(" + result.Pdu.VbList[2].Oid.ToString() + ") (" + SnmpConstants.GetTypeName(result.Pdu.VbList[2].Value.Type) + "): " + "\n\t" + result.Pdu.VbList[2].Value.ToString();
                        rtb.Text = rtb.Text + "\n" + "ifPhysAddress(" + result.Pdu.VbList[3].Oid.ToString() + ") (" + SnmpConstants.GetTypeName(result.Pdu.VbList[3].Value.Type) + "): " + "\n\t" + result.Pdu.VbList[3].Value.ToString();
                        rtb.Text = rtb.Text + "\n" + "ifAdminStatus(" + result.Pdu.VbList[4].Oid.ToString() + ") (" + SnmpConstants.GetTypeName(result.Pdu.VbList[4].Value.Type) + "): " + "\n\t" + GetStatus(int.Parse(result.Pdu.VbList[4].Value.ToString()));
                        rtb.Text = rtb.Text + "\n" + "ifOperStatus(" + result.Pdu.VbList[5].Oid.ToString() + ") (" + SnmpConstants.GetTypeName(result.Pdu.VbList[5].Value.Type) + "): " + "\n\t" + GetStatus(int.Parse(result.Pdu.VbList[5].Value.ToString()));
                    }
                }
                else
                {
                    rtb.Text = "No response received from SNMP agent.";
                }
                target.Close();
            }
            catch (Exception ex)
            {
                rtb.Text = "Đã xảy ra lỗi: " + ex.Message.ToString();
            }
        }

        private void GetMore(int n)
        {
            OctetString community = new OctetString(txtConStr.Text);
            AgentParameters param = new AgentParameters(community);
            param.Version = SnmpVersion.Ver1;
            try
            {
                IpAddress agent = new IpAddress(txtIPAgent.Text);
                UdpTarget target = new UdpTarget((IPAddress)agent, 161, 2000, 1);
                Pdu pdu = new Pdu(PduType.Get);
                string[] row;
                for (int i = 1; i <= n; i++)
                {
                    pdu.VbList.Add("1.3.6.1.2.1.2.2.1.2." + i.ToString());
                    pdu.VbList.Add("1.3.6.1.2.1.2.2.1.3." + i.ToString());
                    pdu.VbList.Add("1.3.6.1.2.1.2.2.1.5." + i.ToString());
                    pdu.VbList.Add("1.3.6.1.2.1.2.2.1.10." + i.ToString());
                    pdu.VbList.Add("1.3.6.1.2.1.2.2.1.16." + i.ToString());
                    SnmpV1Packet result = (SnmpV1Packet)target.Request(pdu, param);
                    row = new string[] { i.ToString(), result.Pdu.VbList[0].Value.ToString(), GetType(int.Parse(result.Pdu.VbList[1].Value.ToString())), result.Pdu.VbList[2].Value.ToString(), result.Pdu.VbList[3].Value.ToString(), result.Pdu.VbList[4].Value.ToString() };
                    dgvList.Rows.Add(row);
                    pdu.Reset();
                }
                target.Close();
              }
            catch (Exception ex)
            {
                rtbGuiGet.Text = "Đã xảy ra lỗi: " + ex.Message.ToString();
            }

}
        private void Get(int n)
        {
            OctetString community = new OctetString(txtConStr.Text);
            AgentParameters param = new AgentParameters(community);
            param.Version = SnmpVersion.Ver1;
            try
            {
                IpAddress agent = new IpAddress(txtIPAgent.Text);
                UdpTarget target = new UdpTarget((IPAddress)agent, 161, 2000, 1);
                
                Pdu pdu = new Pdu(PduType.Get);
                pdu.VbList.Add("1.3.6.1.2.1.1.1." + n.ToString()); //sysDescr
                pdu.VbList.Add("1.3.6.1.2.1.1.2." + n.ToString()); //sysObjectID
                pdu.VbList.Add("1.3.6.1.2.1.1.3." + n.ToString()); //sysUpTime
                pdu.VbList.Add("1.3.6.1.2.1.1.4." + n.ToString()); //sysContact
                pdu.VbList.Add("1.3.6.1.2.1.1.5." + n.ToString()); //sysName
                pdu.VbList.Add("1.3.6.1.2.1.2.1." + n.ToString()); //ifNumbber
                SnmpV1Packet result = (SnmpV1Packet)target.Request(pdu, param);
                
                if (result != null)
                {
                    if (result.Pdu.ErrorStatus != 0)
                    {
                        rtbGuiGet.Text = "Error in SNMP reply. Error " + result.Pdu.ErrorStatus + " index " + result.Pdu.ErrorIndex;
                    }
                    else
                    {
                        rtbGuiGet.Text = "sysDescr(" + result.Pdu.VbList[0].Oid.ToString() + ") (" + SnmpConstants.GetTypeName(result.Pdu.VbList[0].Value.Type) + "): " + result.Pdu.VbList[0].Value.ToString();
                        rtbGuiGet.Text = rtbGuiGet.Text + "\n" + "sysObjectID(" + result.Pdu.VbList[1].Oid.ToString() + ") (" + SnmpConstants.GetTypeName(result.Pdu.VbList[1].Value.Type) + "): " + result.Pdu.VbList[1].Value.ToString();
                        rtbGuiGet.Text = rtbGuiGet.Text + "\n" + "sysUpTime(" + result.Pdu.VbList[2].Oid.ToString() + ") (" + SnmpConstants.GetTypeName(result.Pdu.VbList[2].Value.Type) + "): " + result.Pdu.VbList[2].Value.ToString();
                        rtbGuiGet.Text = rtbGuiGet.Text + "\n" + "sysContact(" + result.Pdu.VbList[3].Oid.ToString() + ") (" + SnmpConstants.GetTypeName(result.Pdu.VbList[3].Value.Type) + "): " + result.Pdu.VbList[3].Value.ToString();
                        rtbGuiGet.Text = rtbGuiGet.Text + "\n" + "sysName(" + result.Pdu.VbList[4].Oid.ToString() + ") (" + SnmpConstants.GetTypeName(result.Pdu.VbList[4].Value.Type) + "): " + result.Pdu.VbList[4].Value.ToString();
                        rtbGuiGet.Text = rtbGuiGet.Text + "\n" + "ifNumber(" + result.Pdu.VbList[5].Oid.ToString() + ") (" + SnmpConstants.GetTypeName(result.Pdu.VbList[5].Value.Type) + "): " + result.Pdu.VbList[5].Value.ToString();
                        GetMore(int.Parse(result.Pdu.VbList[5].Value.ToString()));
                    }
                }
                else
                {
                    rtbGuiGet.Text = "No response received from SNMP agent.";
                }
                target.Close();
            }
            catch (Exception ex)
            {
                rtbGuiGet.Text = "Đã xảy ra lỗi: " + ex.Message.ToString();
            }
        }
        private void GetDisk()
        {
            OctetString community = new OctetString(txtConStr.Text);
            AgentParameters param = new AgentParameters(community);
            param.Version = SnmpVersion.Ver1;
            try
            {
                IpAddress agent = new IpAddress(txtIPAgent.Text);
                UdpTarget target = new UdpTarget((IPAddress)agent, 161, 2000, 1);

                Pdu pdu = new Pdu(PduType.Get);
                pdu.VbList.Add("1.3.6.1.2.1.1.1.0"); //sysDescr
                pdu.VbList.Add("1.3.6.1.2.1.1.2.0"); //sysObjectID
                pdu.VbList.Add("1.3.6.1.2.1.1.3.0"); //sysUpTime
                pdu.VbList.Add("1.3.6.1.2.1.1.4.0"); //sysContact
                pdu.VbList.Add("1.3.6.1.2.1.1.5.0"); //sysName
                pdu.VbList.Add("1.3.6.1.2.1.25.1.2.0"); //hrSystemDate
                pdu.VbList.Add("1.3.6.1.2.1.25.1.5.0"); //hrSystemNumUsers
                pdu.VbList.Add("1.3.6.1.2.1.25.1.6.0"); //hrSystemProcesses
                pdu.VbList.Add("1.3.6.1.2.1.25.2.2.0"); //hrMemorySize
                //pdu.VbList.Add("1.3.6.1.2.1.1.5." + n.ToString()); //sysName
                //pdu.VbList.Add("1.3.6.1.2.1.2.1." + n.ToString()); //ifNumbber
                SnmpV1Packet result = (SnmpV1Packet)target.Request(pdu, param);

                if (result != null)
                {
                    if (result.Pdu.ErrorStatus != 0)
                    {
                        rtbGuiGet.Text = "Error in SNMP reply. Error " + result.Pdu.ErrorStatus + " index " + result.Pdu.ErrorIndex;
                    }
                    else
                    {
                        // Reply variables are returned in the same order as they were added
                        //  to the VbList
                        ////////////////////////////////////
                        //rtbAddInfo.Text = "hrSystemDate(" + result.Pdu.VbList[0].Oid.ToString() + ") (" + SnmpConstants.GetTypeName(result.Pdu.VbList[0].Value.Type) + "):\n\t" + result.Pdu.VbList[0].Value.ToString();
                        //rtbAddInfo.Text += "\n\t-------------------\n\t-------------------\n" + "hrSystemNumUsers(" + result.Pdu.VbList[1].Oid.ToString() + ") (" + SnmpConstants.GetTypeName(result.Pdu.VbList[1].Value.Type) + "): " + result.Pdu.VbList[1].Value.ToString();
                        //rtbAddInfo.Text += "\n\t-------------------\n" + "hrSystemProcesses(" + result.Pdu.VbList[2].Oid.ToString() + ") (" + SnmpConstants.GetTypeName(result.Pdu.VbList[2].Value.Type) + "): " + result.Pdu.VbList[2].Value.ToString();
                        rtbAddInfo.Text += "" + "hrMemorySize(" + result.Pdu.VbList[3].Oid.ToString() + ") (" + SnmpConstants.GetTypeName(result.Pdu.VbList[3].Value.Type) + "): " + result.Pdu.VbList[3].Value.ToString();
                        for (int i=1;i<10;i++)
                        {
                            pdu.Reset();
                            pdu.VbList.Add("1.3.6.1.2.1.25.2.3.1.3."+i.ToString());
                            try
                            {
                                result = (SnmpV1Packet)target.Request(pdu, param);
                                if (result.Pdu.VbList[0].Value.ToString() != "Null")  rtbAddInfo.Text += "\n\t" + "hrStorageDescr." + i.ToString() +"(" + result.Pdu.VbList[0].Oid.ToString() + ") (" + SnmpConstants.GetTypeName(result.Pdu.VbList[0].Value.Type) + "): " + result.Pdu.VbList[0].Value.ToString();
                            }
                            catch(Exception)
                            { }
                        }
                    }
                }
                else
                {
                    rtbAddInfo.Text = "No response received from SNMP agent.";
                }
                target.Close();
            }
            catch (Exception ex)
            {
                rtbGuiGet.Text = "Đã xảy ra lỗi: " + ex.Message.ToString();
            }
        }
        private void btnGuiGet_Click(object sender, EventArgs e)
        {
            rtbAddInfo.Text = "";
            rtbGuiGet.Text = "";
            rtbInfo.Text = "";
            while (dgvList.Rows.Count > 0) dgvList.Rows.RemoveAt(0);
            Get(0);
            GetDisk();
        }

        private void dgvList_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            dong = e.RowIndex;
            GetOne(dong, rtbInfo);
        }

        private void SNMPForm_Load(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            timer1.Stop();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            
        }
        private string GetType(int x)
        {
            string y=string.Empty;
            int dem = 0;
            string z = "other(1),regular1822(2),hdh1822(3),ddnX25(4),rfc877x25(5),ethernetCsmacd(6),iso88023Csmacd(7),iso88024TokenBus(8),iso88025TokenRing(9),iso88026Man(10),starLan(11),proteon10Mbit(12),proteon80Mbit(13),hyperchannel(14),fddi(15),lapb(16),sdlc(17),ds1(18),e1(19),basicISDN(20),primaryISDN(21),propPointToPointSerial(22),ppp(23),softwareLoopback(24),eon(25),ethernet3Mbit(26),nsip(27),slip(28),ultra(29),ds3(30),sip(31),frameRelay(32),rs232(33),para(34),arcnet(35),arcnetPlus(36),atm(37),miox25(38),sonet(39),x25ple(40),iso88022llc(41),localTalk(42),smdsDxi(43),frameRelayService(44),v35(45),hssi(46),hippi(47),modem(48),aal5(49),sonetPath(50),sonetVT(51),smdsIcip(52),propVirtual(53),propMultiplexor(54),ieee80212(55),fibreChannel(56),hippiInterface(57),frameRelayInterconnect(58),aflane8023(59),aflane8025(60),cctEmul(61),fastEther(62),isdn(63),v11(64),v36(65),g703at64k(66),g703at2mb(67),qllc(68),fastEtherFX(69),channel(70),ieee80211(71),ibm370parChan(72),escon(73),dlsw(74),isdns(75),isdnu(76),lapd(77),ipSwitch(78),rsrb(79),atmLogical(80),ds0(81),ds0Bundle(82),bsc(83),async(84),cnr(85),iso88025Dtr(86),eplrs(87),arap(88),propCnls(89),hostPad(90),termPad(91),frameRelayMPI(92),x213(93),adsl(94),radsl(95),sdsl(96),vdsl(97),iso88025CRFPInt(98),myrinet(99),voiceEM(100),voiceFXO(101),voiceFXS(102),voiceEncap(103),voiceOverIp(104),atmDxi(105),atmFuni(106),atmIma(107),pppMultilinkBundle(108),ipOverCdlc(109),ipOverClaw(110),stackToStack(111),virtualIpAddress(112),mpc(113),ipOverAtm(114),iso88025Fiber(115),tdlc(116),gigabitEthernet(117),hdlc(118),lapf(119),v37(120),x25mlp(121),x25huntGroup(122),trasnpHdlc(123),interleave(124),fast(125),ip(126),docsCableMaclayer(127),docsCableDownstream(128),docsCableUpstream(129),a12MppSwitch(130),tunnel(131),coffee(132),ces(133),atmSubInterface(134),l2vlan(135),l3ipvlan(136),l3ipxvlan(137),digitalPowerline(138),mediaMailOverIp(139),dtm(140),dcn(141),ipForward(142),msdsl(143),ieee1394(144),if-gsn(145),dvbRccMacLayer(146),dvbRccDownstream(147),dvbRccUpstream(148),atmVirtual(149),mplsTunnel(150),srp(151),voiceOverAtm(152),voiceOverFrameRelay(153),idsl(154),compositeLink(155),ss7SigLink(156),propWirelessP2P(157),frForward(158),rfc1483(159),usb(160),ieee8023adLag(161),bgppolicyaccounting(162),frf16MfrBundle(163),h323Gatekeeper(164),h323Proxy(165),mpls(166),mfSigLink(167),hdsl2(168),shdsl(169),ds1FDL(170),pos(171),dvbAsiIn(172),dvbAsiOut(173),plc(174),nfas(175),tr008(176),gr303RDT(177),gr303IDT(178),isup(179),propDocsWirelessMaclayer(180),propDocsWirelessDownstream(181),propDocsWirelessUpstream(182),hiperlan2(183),propBWAp2Mp(184),sonetOverheadChannel(185),digitalWrapperOverheadChannel(186),aal2(187),radioMAC(188),atmRadio(189),imt(190),mvl(191),reachDSL(192),frDlciEndPt(193),atmVciEndPt(194),opticalChannel(195),opticalTransport(196),propAtm(197),voiceOverCable(198),infiniband(199),teLink(200),q2931(201),virtualTg(202),sipTg(203),sipSig(204),docsCableUpstreamChannel(205),econet(206),pon155(207),pon622(208),bridge(209),linegroup(210),voiceEMFGD(211),voiceFGDEANA(212),voiceDID(213),mpegTransport(214),sixToFour(215),gtp(216),pdnEtherLoop1(217),pdnEtherLoop2(218),opticalChannelGroup(219),homepna(220),gfp(221),ciscoISLvlan(222),actelisMetaLOOP(223),fcipLink(224),rpr(225),qam(226), lmp(227), cblVectaStar(228), docsCableMCmtsDownstream(229), adsl2(230), macSecControlledIF(231), macSecUncontrolledIF(232), aviciOpticalEther(233), atmbond(234), voiceFGDOS(235), mocaVersion1(236), ieee80216WMAN(237), adsl2plus(238), dvbRcsMacLayer(239), dvbTdm(240), dvbRcsTdma(241)";
            //char[] tmp = z.ToCharArray();
            for (int i=0;i<z.Length;i++)
            {
                if ( z[i] == ',') dem++;
                if (dem == x - 1) y = y + z[i];
                if (dem == x) break;
            }
            if (y == string.Empty) y = "other"; else y = y.Substring(1);
            return y;
        }
        private string GetStatus(int x)
        {
            string y = string.Empty;
            switch (x)
            {
                case 1: y = "up"; break;
                case 2:
                    y = "down"; break;
                case 3:
                    y = "testing"; break;
                case 4:
                    y = "unknown"; break;
                case 5:
                    y = "dormant"; break;
                case 6:
                    y = "notPresent"; break;
                case 7:
                    y = "lowerLayerDown"; break;
            }

            return y;
        }
        private string GetDt(string x)
        {
            string y = string.Empty;
            return y;
        }

    }
}
