// Generated by the protocol buffer compiler.  DO NOT EDIT!
// source: Sha1Wire.proto
#pragma warning disable 1591, 0612, 3021

#region Designer generated code

using pb = global::Google.Protobuf;
using pbr = global::Google.Protobuf.Reflection;

namespace SourceCode.Chasm.IO.Proto.Wire
{
    /// <summary>Holder for reflection information generated from Sha1Wire.proto</summary>
    public static partial class Sha1WireReflection
    {
        #region Descriptor

        /// <summary>File descriptor for Sha1Wire.proto</summary>
        public static pbr::FileDescriptor Descriptor
        {
            get { return descriptor; }
        }

        private static pbr::FileDescriptor descriptor;

        static Sha1WireReflection()
        {
            byte[] descriptorData = global::System.Convert.FromBase64String(
                string.Concat(
                  "Cg5TaGExV2lyZS5wcm90byI3CghTaGExV2lyZRINCgVCbGl0MBgBIAEoBBIN",
                  "CgVCbGl0MRgCIAEoBBINCgVCbGl0MhgDIAEoDUIhqgIeU291cmNlQ29kZS5D",
                  "aGFzbS5JTy5Qcm90by5XaXJlYgZwcm90bzM="));
            descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
                new pbr::FileDescriptor[] { },
                new pbr::GeneratedClrTypeInfo(null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::SourceCode.Chasm.IO.Proto.Wire.Sha1Wire), global::SourceCode.Chasm.IO.Proto.Wire.Sha1Wire.Parser, new[]{ "Blit0", "Blit1", "Blit2" }, null, null, null)
                }));
        }

        #endregion
    }

    #region Messages

    /// <summary>
    /// 20 bytes
    /// </summary>
    public sealed partial class Sha1Wire : pb::IMessage<Sha1Wire>
    {
        private static readonly pb::MessageParser<Sha1Wire> _parser = new pb::MessageParser<Sha1Wire>(() => new Sha1Wire());

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        public static pb::MessageParser<Sha1Wire> Parser { get { return _parser; } }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        public static pbr::MessageDescriptor Descriptor
        {
            get { return global::SourceCode.Chasm.IO.Proto.Wire.Sha1WireReflection.Descriptor.MessageTypes[0]; }
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        pbr::MessageDescriptor pb::IMessage.Descriptor
        {
            get { return Descriptor; }
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        public Sha1Wire()
        {
            OnConstruction();
        }

        partial void OnConstruction();

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        public Sha1Wire(Sha1Wire other) : this()
        {
            blit0_ = other.blit0_;
            blit1_ = other.blit1_;
            blit2_ = other.blit2_;
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        public Sha1Wire Clone()
        {
            return new Sha1Wire(this);
        }

        /// <summary>Field number for the "Blit0" field.</summary>
        public const int Blit0FieldNumber = 1;

        private ulong blit0_;

        /// <summary>
        /// 0..7
        /// </summary>
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        public ulong Blit0
        {
            get { return blit0_; }
            set
            {
                blit0_ = value;
            }
        }

        /// <summary>Field number for the "Blit1" field.</summary>
        public const int Blit1FieldNumber = 2;

        private ulong blit1_;

        /// <summary>
        /// 8..15
        /// </summary>
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        public ulong Blit1
        {
            get { return blit1_; }
            set
            {
                blit1_ = value;
            }
        }

        /// <summary>Field number for the "Blit2" field.</summary>
        public const int Blit2FieldNumber = 3;

        private uint blit2_;

        /// <summary>
        /// 16..19
        /// </summary>
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        public uint Blit2
        {
            get { return blit2_; }
            set
            {
                blit2_ = value;
            }
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        public override bool Equals(object other)
        {
            return Equals(other as Sha1Wire);
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        public bool Equals(Sha1Wire other)
        {
            if (ReferenceEquals(other, null))
            {
                return false;
            }
            if (ReferenceEquals(other, this))
            {
                return true;
            }
            if (Blit0 != other.Blit0) return false;
            if (Blit1 != other.Blit1) return false;
            if (Blit2 != other.Blit2) return false;
            return true;
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        public override int GetHashCode()
        {
            int hash = 1;
            if (Blit0 != 0UL) hash ^= Blit0.GetHashCode();
            if (Blit1 != 0UL) hash ^= Blit1.GetHashCode();
            if (Blit2 != 0) hash ^= Blit2.GetHashCode();
            return hash;
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        public override string ToString()
        {
            return pb::JsonFormatter.ToDiagnosticString(this);
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        public void WriteTo(pb::CodedOutputStream output)
        {
            if (Blit0 != 0UL)
            {
                output.WriteRawTag(8);
                output.WriteUInt64(Blit0);
            }
            if (Blit1 != 0UL)
            {
                output.WriteRawTag(16);
                output.WriteUInt64(Blit1);
            }
            if (Blit2 != 0)
            {
                output.WriteRawTag(24);
                output.WriteUInt32(Blit2);
            }
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        public int CalculateSize()
        {
            int size = 0;
            if (Blit0 != 0UL)
            {
                size += 1 + pb::CodedOutputStream.ComputeUInt64Size(Blit0);
            }
            if (Blit1 != 0UL)
            {
                size += 1 + pb::CodedOutputStream.ComputeUInt64Size(Blit1);
            }
            if (Blit2 != 0)
            {
                size += 1 + pb::CodedOutputStream.ComputeUInt32Size(Blit2);
            }
            return size;
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        public void MergeFrom(Sha1Wire other)
        {
            if (other == null)
            {
                return;
            }
            if (other.Blit0 != 0UL)
            {
                Blit0 = other.Blit0;
            }
            if (other.Blit1 != 0UL)
            {
                Blit1 = other.Blit1;
            }
            if (other.Blit2 != 0)
            {
                Blit2 = other.Blit2;
            }
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        public void MergeFrom(pb::CodedInputStream input)
        {
            uint tag;
            while ((tag = input.ReadTag()) != 0)
            {
                switch (tag)
                {
                    default:
                        input.SkipLastField();
                        break;

                    case 8:
                        {
                            Blit0 = input.ReadUInt64();
                            break;
                        }
                    case 16:
                        {
                            Blit1 = input.ReadUInt64();
                            break;
                        }
                    case 24:
                        {
                            Blit2 = input.ReadUInt32();
                            break;
                        }
                }
            }
        }
    }

    #endregion
}

#endregion Designer generated code
