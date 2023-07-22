using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace WindowsActivator
{
    public static class GetKey
    {
       
        //It gives the wright KMS configuration key using the Windows Edition, Windows NT Kernel version and the Windows Build number.
        public static string Key(string WinVersion, string WinBuild, string WinEdition)
        {
            string Key = "";
           
            switch(WinVersion)
            {
                case "6.0":
                    switch(WinEdition)
                    {
                        case "Business":

                            Key = "YFKBB-PQJJV-G996G-VWGXY-2V3X8";
                            break;
                        case "BusinessN":
                            Key = "HMBQG-8H2RH-C77VX-27R82-VMQBT";
                            break;
                        case "Enterprise":
                            Key = "VKK3X-68KWM-X2YGT-QR4M6-4BWMV";
                            break;
                        case "EnterpriseN":
                            Key = "VTC42-BM838-43QHV-84HX6-XJXKV";
                            break;
                        

                    }
                    break;
                case "6.1":
                    switch(WinEdition)
                    {
                        case "Professional":
                            Key = "FJ82H-XT6CR-J8D7P-XQJJ2-GPDD4";
                            break;
                        case "ProfessionalN":
                            Key = "MRPKT-YTG23-K7D7T-X2JMM-QY7MG";
                            break;
                        case "Enterprise":
                            Key = "33PXH-7Y6KF-2VJC9-XBBR8-HVTHH";
                            break;
                        case "EnterpriseN":
                            Key = "YDRBP-3D83W-TY26F-D46B2-XCKRJ";
                            break;
                        case "ProfessionalE":
                            Key = "W82YF-2Q76Y-63HXB-FGJG9-GF7QX";
                            break;
                        case "EnterpriseE":
                            Key = "C29WB-22CC8-VJ326-GHFJW-H9DH4";
                            break;

                    }
                    break;
                case "6.2":
                    switch(WinEdition)
                    {
                        case "Professional":
                            Key = "NG4HW-VH26C-733KW-K6F98-J8CK4";
                            break;
                        case "ProfessionalN":
                            Key = "XCVCF-2NXM9-723PB-MHCB7-2RYQQ";
                            break;
                        case "Enterprise":
                            Key = "32JNW-9KQ84-P47T8-D8GGY-CWCK7";
                            break;
                        case "EnterpriseN":
                            Key = "JMNMF-RHW7P-DMY6X-RF3DR-X2BQT";
                            break;
                    }
                    break;
                case "6.3":
                    switch(WinEdition)
                    {
                        case "Professional":
                            Key = "GCRJD-8NW9H-F2CDX-CCM8D-9D6T9";
                            break;
                        case "ProfessionalN":
                            Key = "HMCNV-VVBFX-7HMBH-CTY9B-B4FXY";
                            break;
                        case "Enterprise":
                            Key = "MHF9N-XY6XB-WVXMC-BTDCT-MKKG7";
                            break;
                        case "EnterpriseN":
                            Key = "TT4HM-HN7YT-62K67-RGRQJ-JFFXW";
                            break;

                    }
                    break;
                case "10.0":
                    switch(WinEdition)
                    {
                        case "Core":
                            Key = "TX9XD-98N7V-6WMQ6-BX7FG-H8Q99";
                            break;
                        case "CoreN":
                            Key = "3KHY7-WNT83-DGQKR-F7HPR-844BM";
                            break;
                        case "CoreSingleLanguage":
                            Key = "7HNRX-D7KGG-3K4RQ-4WPJ4-YTDFH";
                            break;
                        case "Professional":
                            Key = "W269N-WFGWX-YVC9B-4J6C9-T83GX";
                            break;
                        case "ProfessionalN":
                            Key = "MH37W-N47XK-V7XM9-C7227-GCQG9";
                            break;
                        case "ProfessionalWorkstation":
                            Key = "NRG8B-VKK3Q-CXVCJ-9G2XF-6Q84J";
                            break;
                        case "ProfessionalWorkstationN":
                            Key = "9FNHH-K3HBT-3W4TD-6383H-6XYWF";
                            break;
                        case "ProfessionalEducation":
                            Key = "6TP4R-GNPTD-KYYHQ-7B7DP-J447Y";
                            break;
                        case "ProfessionalEducationN":
                            Key = "YVWGF-BXNMC-HTQYQ-CPQ99-66QFC";
                            break;
                        case "Education":
                            Key = "NW6C2-QMPVW-D7KKK-3GKT6-VCFB2";
                            break;
                        case "EducationN":
                            Key = "2WH4N-8QGBV-H22JP-CT43Q-MDWWJ";
                            break;
                        case "Enterprise":
                            Key = "NPPR9-FWDCX-D2C8J-H872K-2YT43";
                            break;
                        case "EnterpriseN":
                            Key = "DPH2V-TTNVB-4X9Q3-TJR4H-KHJW4";
                            break;
                        case "EnterpriseG":
                            Key = "YYVX9-NTFWV-6MDM3-9PT4T-4M68B";
                            break;
                        case "EnterpriseGN":
                            Key = "44RPN-FTY23-9VTTB-MP9BX-T84FV";
                            break;
                        case "EnterpriseS":
                            switch(WinBuild)
                            {
                                case "10240":
                                    Key = "WNMTR-4C88C-JK8YV-HQ7T2-76DF9";
                                    break;
                                case "14393":
                                    Key = "DCPHK-NFMTC-H88MJ-PFHPY-QJ4BJ";
                                    break;
                                default:
                                    Key = "M7XTQ-FN8P6-TTKYV-9D4CC-J462D";
                                    break;
                            }
                            break;
                        case "EnterpriseSN":
                            switch (WinBuild)
                            {
                                case "10240":
                                    Key = "2F77B-TNFGY-69QQF-B8YKP-D69TJ";
                                    break;
                                case "14393":
                                    Key = "QFFDN-GRT3P-VKWWX-X7T3R-8B639";
                                    break;
                                default:
                                    Key = "92NFX-8DJQP-P6BBQ-THF9C-7CG2H";
                                    break;
                            }
                            break;
                    }
                    break;

            }
            return Key;
        }
    }
}
