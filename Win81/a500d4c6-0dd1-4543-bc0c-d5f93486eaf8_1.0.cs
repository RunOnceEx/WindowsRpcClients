//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

// Source Executable: c:\windows\system32\TimeBrokerServer.dll
// Interface ID: a500d4c6-0dd1-4543-bc0c-d5f93486eaf8
// Interface Version: 1.0



namespace rpc_a500d4c6_0dd1_4543_bc0c_d5f93486eaf8_1_0
{
    
    #region Marshal Helpers
    internal class _Marshal_Helper : NtApiDotNet.Ndr.Marshal.NdrMarshalBuffer
    {
        public void Write_0(Struct_0 p0)
        {
            WriteStruct<Struct_0>(p0);
        }
        public void Write_1(Union_1 p0, long p1)
        {
            WriteUnion<Union_1>(p0, p1);
        }
        public void Write_2(Struct_2 p0)
        {
            WriteStruct<Struct_2>(p0);
        }
        public void Write_3(Struct_3 p0)
        {
            WriteStruct<Struct_3>(p0);
        }
        public void Write_4(Struct_4 p0)
        {
            WriteStruct<Struct_4>(p0);
        }
        public void Write_5(Struct_5 p0)
        {
            WriteStruct<Struct_5>(p0);
        }
        public void Write_6(Struct_7 p0)
        {
            WriteStruct<Struct_7>(p0);
        }
        public void Write_7(sbyte[] p0, long p1)
        {
            WriteConformantArray<sbyte>(p0, p1);
        }
        public void Write_8(int[] p0)
        {
            WriteFixedPrimitiveArray<int>(p0, 2);
        }
        public void Write_9(System.Guid[] p0, long p1)
        {
            WriteConformantArrayCallback<System.Guid>(p0, new System.Action<System.Guid>(this.WriteGuid), p1);
        }
        public void Write_10(Struct_7[] p0, long p1)
        {
            WriteConformantStructArray<Struct_7>(p0, p1);
        }
    }
    internal class _Unmarshal_Helper : NtApiDotNet.Ndr.Marshal.NdrUnmarshalBuffer
    {
        public _Unmarshal_Helper(NtApiDotNet.Win32.Rpc.RpcClientResponse r) : 
                base(r.NdrBuffer, r.Handles, r.DataRepresentation)
        {
        }
        public _Unmarshal_Helper(byte[] ba) : 
                base(ba)
        {
        }
        public Struct_0 Read_0()
        {
            return ReadStruct<Struct_0>();
        }
        public Union_1 Read_1()
        {
            return ReadStruct<Union_1>();
        }
        public Struct_2 Read_2()
        {
            return ReadStruct<Struct_2>();
        }
        public Struct_3 Read_3()
        {
            return ReadStruct<Struct_3>();
        }
        public Struct_4 Read_4()
        {
            return ReadStruct<Struct_4>();
        }
        public Struct_5 Read_5()
        {
            return ReadStruct<Struct_5>();
        }
        public Struct_7 Read_6()
        {
            return ReadStruct<Struct_7>();
        }
        public sbyte[] Read_7()
        {
            return ReadConformantArray<sbyte>();
        }
        public int[] Read_8()
        {
            return ReadFixedPrimitiveArray<int>(2);
        }
        public System.Guid[] Read_9()
        {
            return ReadConformantArrayCallback<System.Guid>(new System.Func<System.Guid>(this.ReadGuid));
        }
        public Struct_7[] Read_10()
        {
            return ReadConformantStructArray<Struct_7>();
        }
    }
    #endregion
    #region Complex Types
    public struct Struct_0 : NtApiDotNet.Ndr.Marshal.INdrStructure
    {
        void NtApiDotNet.Ndr.Marshal.INdrStructure.Marshal(NtApiDotNet.Ndr.Marshal.NdrMarshalBuffer m)
        {
            Marshal(((_Marshal_Helper)(m)));
        }
        private void Marshal(_Marshal_Helper m)
        {
            m.WriteEnum16(Member0);
            m.Write_1(Member4, Member0);
            m.WriteInt32(Member24);
            m.WriteEmbeddedPointer<sbyte[], long>(Member28, new System.Action<sbyte[], long>(m.Write_7), Member24);
        }
        void NtApiDotNet.Ndr.Marshal.INdrStructure.Unmarshal(NtApiDotNet.Ndr.Marshal.NdrUnmarshalBuffer u)
        {
            Unmarshal(((_Unmarshal_Helper)(u)));
        }
        private void Unmarshal(_Unmarshal_Helper u)
        {
            Member0 = u.ReadEnum16();
            Member4 = u.Read_1();
            Member24 = u.ReadInt32();
            Member28 = u.ReadEmbeddedPointer<sbyte[]>(new System.Func<sbyte[]>(u.Read_7), false);
        }
        int NtApiDotNet.Ndr.Marshal.INdrStructure.GetAlignment()
        {
            return 4;
        }
        public NtApiDotNet.Ndr.Marshal.NdrEnum16 Member0;
        public Union_1 Member4;
        public int Member24;
        public NtApiDotNet.Ndr.Marshal.NdrEmbeddedPointer<sbyte[]> Member28;
        public static Struct_0 CreateDefault()
        {
            return new Struct_0();
        }
        public Struct_0(NtApiDotNet.Ndr.Marshal.NdrEnum16 Member0, Union_1 Member4, int Member24, sbyte[] Member28)
        {
            this.Member0 = Member0;
            this.Member4 = Member4;
            this.Member24 = Member24;
            this.Member28 = Member28;
        }
    }
    public struct Union_1 : NtApiDotNet.Ndr.Marshal.INdrNonEncapsulatedUnion
    {
        void NtApiDotNet.Ndr.Marshal.INdrStructure.Marshal(NtApiDotNet.Ndr.Marshal.NdrMarshalBuffer m)
        {
            throw new System.NotImplementedException();
        }
        void NtApiDotNet.Ndr.Marshal.INdrNonEncapsulatedUnion.Marshal(NtApiDotNet.Ndr.Marshal.NdrMarshalBuffer m, long l)
        {
            Selector = ((NtApiDotNet.Ndr.Marshal.NdrEnum16)(l));
            Marshal(((_Marshal_Helper)(m)));
        }
        private void Marshal(_Marshal_Helper m)
        {
            m.WriteEnum16(Selector);
            if ((Selector == 0))
            {
                m.Write_2(Arm_0);
                goto done;
            }
            if ((Selector == 1))
            {
                m.Write_2(Arm_1);
                goto done;
            }
            if ((Selector == 2))
            {
                m.Write_4(Arm_2);
                goto done;
            }
            if ((Selector == 3))
            {
                m.Write_5(Arm_3);
                goto done;
            }
            if ((Selector == 4))
            {
                m.Write_2(Arm_4);
                goto done;
            }
            if ((Selector == 5))
            {
                m.Write_2(Arm_5);
                goto done;
            }
            throw new System.ArgumentException("No matching union selector when marshaling Union_1");
        done:
            return;
        }
        void NtApiDotNet.Ndr.Marshal.INdrStructure.Unmarshal(NtApiDotNet.Ndr.Marshal.NdrUnmarshalBuffer u)
        {
            Unmarshal(((_Unmarshal_Helper)(u)));
        }
        private void Unmarshal(_Unmarshal_Helper u)
        {
            Selector = u.ReadEnum16();
            if ((Selector == 0))
            {
                Arm_0 = u.Read_2();
                goto done;
            }
            if ((Selector == 1))
            {
                Arm_1 = u.Read_2();
                goto done;
            }
            if ((Selector == 2))
            {
                Arm_2 = u.Read_4();
                goto done;
            }
            if ((Selector == 3))
            {
                Arm_3 = u.Read_5();
                goto done;
            }
            if ((Selector == 4))
            {
                Arm_4 = u.Read_2();
                goto done;
            }
            if ((Selector == 5))
            {
                Arm_5 = u.Read_2();
                goto done;
            }
            throw new System.ArgumentException("No matching union selector when marshaling Union_1");
        done:
            return;
        }
        int NtApiDotNet.Ndr.Marshal.INdrStructure.GetAlignment()
        {
            return 1;
        }
        private NtApiDotNet.Ndr.Marshal.NdrEnum16 Selector;
        public Struct_2 Arm_0;
        public Struct_2 Arm_1;
        public Struct_4 Arm_2;
        public Struct_5 Arm_3;
        public Struct_2 Arm_4;
        public Struct_2 Arm_5;
        public static Union_1 CreateDefault()
        {
            return new Union_1();
        }
        public Union_1(NtApiDotNet.Ndr.Marshal.NdrEnum16 Selector, Struct_2 Arm_0, Struct_2 Arm_1, Struct_4 Arm_2, Struct_5 Arm_3, Struct_2 Arm_4, Struct_2 Arm_5)
        {
            this.Selector = Selector;
            this.Arm_0 = Arm_0;
            this.Arm_1 = Arm_1;
            this.Arm_2 = Arm_2;
            this.Arm_3 = Arm_3;
            this.Arm_4 = Arm_4;
            this.Arm_5 = Arm_5;
        }
    }
    public struct Struct_2 : NtApiDotNet.Ndr.Marshal.INdrStructure
    {
        void NtApiDotNet.Ndr.Marshal.INdrStructure.Marshal(NtApiDotNet.Ndr.Marshal.NdrMarshalBuffer m)
        {
            Marshal(((_Marshal_Helper)(m)));
        }
        private void Marshal(_Marshal_Helper m)
        {
            m.Write_3(Member0);
            m.WriteInt32(Member10);
            m.WriteInt32(Member14);
            m.WriteInt32(Member18);
            m.WriteInt32(Member1C);
        }
        void NtApiDotNet.Ndr.Marshal.INdrStructure.Unmarshal(NtApiDotNet.Ndr.Marshal.NdrUnmarshalBuffer u)
        {
            Unmarshal(((_Unmarshal_Helper)(u)));
        }
        private void Unmarshal(_Unmarshal_Helper u)
        {
            Member0 = u.Read_3();
            Member10 = u.ReadInt32();
            Member14 = u.ReadInt32();
            Member18 = u.ReadInt32();
            Member1C = u.ReadInt32();
        }
        int NtApiDotNet.Ndr.Marshal.INdrStructure.GetAlignment()
        {
            return 4;
        }
        public Struct_3 Member0;
        public int Member10;
        public int Member14;
        public int Member18;
        public int Member1C;
        public static Struct_2 CreateDefault()
        {
            return new Struct_2();
        }
        public Struct_2(Struct_3 Member0, int Member10, int Member14, int Member18, int Member1C)
        {
            this.Member0 = Member0;
            this.Member10 = Member10;
            this.Member14 = Member14;
            this.Member18 = Member18;
            this.Member1C = Member1C;
        }
    }
    public struct Struct_3 : NtApiDotNet.Ndr.Marshal.INdrStructure
    {
        void NtApiDotNet.Ndr.Marshal.INdrStructure.Marshal(NtApiDotNet.Ndr.Marshal.NdrMarshalBuffer m)
        {
            Marshal(((_Marshal_Helper)(m)));
        }
        private void Marshal(_Marshal_Helper m)
        {
            m.WriteInt16(Member0);
            m.WriteInt16(Member2);
            m.WriteInt16(Member4);
            m.WriteInt16(Member6);
            m.WriteInt16(Member8);
            m.WriteInt16(MemberA);
            m.WriteInt16(MemberC);
            m.WriteInt16(MemberE);
        }
        void NtApiDotNet.Ndr.Marshal.INdrStructure.Unmarshal(NtApiDotNet.Ndr.Marshal.NdrUnmarshalBuffer u)
        {
            Unmarshal(((_Unmarshal_Helper)(u)));
        }
        private void Unmarshal(_Unmarshal_Helper u)
        {
            Member0 = u.ReadInt16();
            Member2 = u.ReadInt16();
            Member4 = u.ReadInt16();
            Member6 = u.ReadInt16();
            Member8 = u.ReadInt16();
            MemberA = u.ReadInt16();
            MemberC = u.ReadInt16();
            MemberE = u.ReadInt16();
        }
        int NtApiDotNet.Ndr.Marshal.INdrStructure.GetAlignment()
        {
            return 2;
        }
        public short Member0;
        public short Member2;
        public short Member4;
        public short Member6;
        public short Member8;
        public short MemberA;
        public short MemberC;
        public short MemberE;
        public static Struct_3 CreateDefault()
        {
            return new Struct_3();
        }
        public Struct_3(short Member0, short Member2, short Member4, short Member6, short Member8, short MemberA, short MemberC, short MemberE)
        {
            this.Member0 = Member0;
            this.Member2 = Member2;
            this.Member4 = Member4;
            this.Member6 = Member6;
            this.Member8 = Member8;
            this.MemberA = MemberA;
            this.MemberC = MemberC;
            this.MemberE = MemberE;
        }
    }
    public struct Struct_4 : NtApiDotNet.Ndr.Marshal.INdrStructure
    {
        void NtApiDotNet.Ndr.Marshal.INdrStructure.Marshal(NtApiDotNet.Ndr.Marshal.NdrMarshalBuffer m)
        {
            Marshal(((_Marshal_Helper)(m)));
        }
        private void Marshal(_Marshal_Helper m)
        {
            m.Write_3(Member0);
            m.WriteInt32(Member10);
            m.WriteInt32(Member14);
            m.WriteInt32(Member18);
        }
        void NtApiDotNet.Ndr.Marshal.INdrStructure.Unmarshal(NtApiDotNet.Ndr.Marshal.NdrUnmarshalBuffer u)
        {
            Unmarshal(((_Unmarshal_Helper)(u)));
        }
        private void Unmarshal(_Unmarshal_Helper u)
        {
            Member0 = u.Read_3();
            Member10 = u.ReadInt32();
            Member14 = u.ReadInt32();
            Member18 = u.ReadInt32();
        }
        int NtApiDotNet.Ndr.Marshal.INdrStructure.GetAlignment()
        {
            return 4;
        }
        public Struct_3 Member0;
        public int Member10;
        public int Member14;
        public int Member18;
        public static Struct_4 CreateDefault()
        {
            return new Struct_4();
        }
        public Struct_4(Struct_3 Member0, int Member10, int Member14, int Member18)
        {
            this.Member0 = Member0;
            this.Member10 = Member10;
            this.Member14 = Member14;
            this.Member18 = Member18;
        }
    }
    public struct Struct_5 : NtApiDotNet.Ndr.Marshal.INdrStructure
    {
        void NtApiDotNet.Ndr.Marshal.INdrStructure.Marshal(NtApiDotNet.Ndr.Marshal.NdrMarshalBuffer m)
        {
            Marshal(((_Marshal_Helper)(m)));
        }
        private void Marshal(_Marshal_Helper m)
        {
            m.WriteInt32(Member0);
            m.WriteInt32(Member4);
            m.WriteInt32(Member8);
            m.WriteInt32(MemberC);
        }
        void NtApiDotNet.Ndr.Marshal.INdrStructure.Unmarshal(NtApiDotNet.Ndr.Marshal.NdrUnmarshalBuffer u)
        {
            Unmarshal(((_Unmarshal_Helper)(u)));
        }
        private void Unmarshal(_Unmarshal_Helper u)
        {
            Member0 = u.ReadInt32();
            Member4 = u.ReadInt32();
            Member8 = u.ReadInt32();
            MemberC = u.ReadInt32();
        }
        int NtApiDotNet.Ndr.Marshal.INdrStructure.GetAlignment()
        {
            return 4;
        }
        public int Member0;
        public int Member4;
        public int Member8;
        public int MemberC;
        public static Struct_5 CreateDefault()
        {
            return new Struct_5();
        }
        public Struct_5(int Member0, int Member4, int Member8, int MemberC)
        {
            this.Member0 = Member0;
            this.Member4 = Member4;
            this.Member8 = Member8;
            this.MemberC = MemberC;
        }
    }
    public struct Struct_7 : NtApiDotNet.Ndr.Marshal.INdrStructure
    {
        void NtApiDotNet.Ndr.Marshal.INdrStructure.Marshal(NtApiDotNet.Ndr.Marshal.NdrMarshalBuffer m)
        {
            Marshal(((_Marshal_Helper)(m)));
        }
        private void Marshal(_Marshal_Helper m)
        {
            m.Write_8(NtApiDotNet.Win32.Rpc.RpcUtils.CheckNull(Member0, "Member0"));
        }
        void NtApiDotNet.Ndr.Marshal.INdrStructure.Unmarshal(NtApiDotNet.Ndr.Marshal.NdrUnmarshalBuffer u)
        {
            Unmarshal(((_Unmarshal_Helper)(u)));
        }
        private void Unmarshal(_Unmarshal_Helper u)
        {
            Member0 = u.Read_8();
        }
        int NtApiDotNet.Ndr.Marshal.INdrStructure.GetAlignment()
        {
            return 4;
        }
        public int[] Member0;
        public static Struct_7 CreateDefault()
        {
            Struct_7 ret = new Struct_7();
            ret.Member0 = new int[2];
            return ret;
        }
        public Struct_7(int[] Member0)
        {
            this.Member0 = Member0;
        }
    }
    #endregion
    #region Client Implementation
    public sealed class Client : NtApiDotNet.Win32.Rpc.RpcClientBase
    {
        public Client() : 
                base("a500d4c6-0dd1-4543-bc0c-d5f93486eaf8", 1, 0)
        {
        }
        private _Unmarshal_Helper SendReceive(int p, _Marshal_Helper m)
        {
            return new _Unmarshal_Helper(SendReceive(p, m.DataRepresentation, m.ToArray(), m.Handles));
        }
        public uint _TbiCreateEvent(string p0, Struct_0 p1, out System.Guid p2)
        {
            _Marshal_Helper m = new _Marshal_Helper();
            m.WriteReferent(p0, new System.Action<string>(m.WriteTerminatedString));
            m.Write_0(p1);
            _Unmarshal_Helper u = SendReceive(0, m);
            p2 = u.ReadGuid();
            return u.ReadUInt32();
        }
        public uint _TbiDeleteEvent(string p0, System.Guid p1)
        {
            _Marshal_Helper m = new _Marshal_Helper();
            m.WriteReferent(p0, new System.Action<string>(m.WriteTerminatedString));
            m.WriteGuid(p1);
            _Unmarshal_Helper u = SendReceive(1, m);
            return u.ReadUInt32();
        }
        public uint TbiEnumerateEvents(string p0, out int p1, out System.Guid[] p2)
        {
            _Marshal_Helper m = new _Marshal_Helper();
            m.WriteReferent(p0, new System.Action<string>(m.WriteTerminatedString));
            _Unmarshal_Helper u = SendReceive(2, m);
            p1 = u.ReadInt32();
            p2 = u.ReadReferent<System.Guid[]>(new System.Func<System.Guid[]>(u.Read_9), false);
            return u.ReadUInt32();
        }
        public uint _TbiQueryEventData(string p0, System.Guid p1, out Struct_0 p2)
        {
            _Marshal_Helper m = new _Marshal_Helper();
            m.WriteReferent(p0, new System.Action<string>(m.WriteTerminatedString));
            m.WriteGuid(p1);
            _Unmarshal_Helper u = SendReceive(3, m);
            p2 = u.Read_0();
            return u.ReadUInt32();
        }
        public uint _TbiUpdateEvent(string p0, System.Guid p1, Struct_0 p2)
        {
            _Marshal_Helper m = new _Marshal_Helper();
            m.WriteReferent(p0, new System.Action<string>(m.WriteTerminatedString));
            m.WriteGuid(p1);
            m.Write_0(p2);
            _Unmarshal_Helper u = SendReceive(4, m);
            return u.ReadUInt32();
        }
        public uint TbiCreateCEvent(Struct_0 p0, out Struct_7 p1, out NtApiDotNet.Ndr.Marshal.NdrContextHandle p2)
        {
            _Marshal_Helper m = new _Marshal_Helper();
            m.Write_0(p0);
            _Unmarshal_Helper u = SendReceive(5, m);
            p1 = u.Read_6();
            p2 = u.ReadContextHandle();
            return u.ReadUInt32();
        }
        public uint TbiDeleteCEvent(Struct_7 p0, ref NtApiDotNet.Ndr.Marshal.NdrContextHandle p1)
        {
            _Marshal_Helper m = new _Marshal_Helper();
            m.Write_6(p0);
            m.WriteContextHandle(p1);
            _Unmarshal_Helper u = SendReceive(6, m);
            p1 = u.ReadContextHandle();
            return u.ReadUInt32();
        }
        public uint TbiEnumerateCEvents(out int p0, out Struct_7[] p1)
        {
            _Marshal_Helper m = new _Marshal_Helper();
            _Unmarshal_Helper u = SendReceive(7, m);
            p0 = u.ReadInt32();
            p1 = u.ReadReferent<Struct_7[]>(new System.Func<Struct_7[]>(u.Read_10), false);
            return u.ReadUInt32();
        }
        public uint TbiQueryCEventData(Struct_7 p0, out Struct_0 p1)
        {
            _Marshal_Helper m = new _Marshal_Helper();
            m.Write_6(p0);
            _Unmarshal_Helper u = SendReceive(8, m);
            p1 = u.Read_0();
            return u.ReadUInt32();
        }
        public uint TbiUpdateCEvent(Struct_7 p0, Struct_0 p1)
        {
            _Marshal_Helper m = new _Marshal_Helper();
            m.Write_6(p0);
            m.Write_0(p1);
            _Unmarshal_Helper u = SendReceive(9, m);
            return u.ReadUInt32();
        }
    }
    #endregion
}

