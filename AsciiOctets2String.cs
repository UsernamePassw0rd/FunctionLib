        static string AsciiOctetsToString(byte[] bytes)
        {
            StringBuilder sb = new StringBuilder(bytes.Length);
            foreach (char c in bytes.Select(b => (char)b))
            {
                switch (c)
                {
                    case '\u0000': sb.Append("<NUL>"); break;
                    case '\u0001': sb.Append("<SOH>"); break;
                    case '\u0002': sb.Append("<STX>"); break;
                    case '\u0003': sb.Append("<ETX>"); break;
                    case '\u0004': sb.Append("<EOT>"); break;
                    case '\u0005': sb.Append("<ENQ>"); break;
                    case '\u0006': sb.Append("<ACK>"); break;
                    case '\u0007': sb.Append("<BEL>"); break;
                    case '\u0008': sb.Append("<BS>"); break;
                    case '\u0009': sb.Append("<HT>"); break;
                    case '\u000A': sb.Append("<LF>"); break;
                    case '\u000B': sb.Append("<VT>"); break;
                    case '\u000C': sb.Append("<FF>"); break;
                    case '\u000D': sb.Append("<CR>"); break;
                    case '\u000E': sb.Append("<SO>"); break;
                    case '\u000F': sb.Append("<SI>"); break;
                    case '\u0010': sb.Append("<DLE>"); break;
                    case '\u0011': sb.Append("<DC1>"); break;
                    case '\u0012': sb.Append("<DC2>"); break;
                    case '\u0013': sb.Append("<DC3>"); break;
                    case '\u0014': sb.Append("<DC4>"); break;
                    case '\u0015': sb.Append("<NAK>"); break;
                    case '\u0016': sb.Append("<SYN>"); break;
                    case '\u0017': sb.Append("<ETB>"); break;
                    case '\u0018': sb.Append("<CAN>"); break;
                    case '\u0019': sb.Append("<EM>"); break;
                    case '\u001A': sb.Append("<SUB>"); break;
                    case '\u001B': sb.Append("<ESC>"); break;
                    case '\u001C': sb.Append("<FS>"); break;
                    case '\u001D': sb.Append("<GS>"); break;
                    case '\u001E': sb.Append("<RS>"); break;
                    case '\u001F': sb.Append("<US>"); break;
                    case '\u007F': sb.Append("<DEL>"); break;
                    default:
                        if (c > '\u007F')
                        {
                            sb.AppendFormat(@"\u{0:X4}", (ushort)c); // in ASCII, any octet in the range 0x80-0xFF doesn't have a character glyph associated with it
                        }
                        else
                        {
                            sb.Append(c);
                        }
                        break;
                }
            }
            return sb.ToString();
        }