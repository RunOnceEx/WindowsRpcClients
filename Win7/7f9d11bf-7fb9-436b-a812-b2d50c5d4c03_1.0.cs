//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

// Source Executable: c:\windows\system32\MPSSVC.dll
// Interface ID: 7f9d11bf-7fb9-436b-a812-b2d50c5d4c03
// Interface Version: 1.0



namespace rpc_7f9d11bf_7fb9_436b_a812_b2d50c5d4c03_1_0
{
    
    #region Marshal Helpers
    internal class _Marshal_Helper : NtApiDotNet.Ndr.Marshal.NdrMarshalBuffer
    {
        public void Write_0(short[] p0, long p1)
        {
            WriteConformantArray<short>(p0, p1);
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
        public short[] Read_0()
        {
            return ReadConformantArray<short>();
        }
    }
    #endregion
    #region Client Implementation
    public sealed class Client : NtApiDotNet.Win32.Rpc.RpcClientBase
    {
        public Client() : 
                base("7f9d11bf-7fb9-436b-a812-b2d50c5d4c03", 1, 0)
        {
        }
        private _Unmarshal_Helper SendReceive(int p, _Marshal_Helper m)
        {
            return new _Unmarshal_Helper(SendReceive(p, m.DataRepresentation, m.ToArray(), m.Handles));
        }
        public int RPC_FWIndicatePortInUse(NtApiDotNet.Ndr.Marshal.NdrEnum16 p0, short p1, int p2)
        {
            _Marshal_Helper m = new _Marshal_Helper();
            m.WriteEnum16(p0);
            m.WriteInt16(p1);
            m.WriteInt32(p2);
            _Unmarshal_Helper u = SendReceive(0, m);
            return u.ReadInt32();
        }
        public int RPC_FWGetIndicatedPortInUse(NtApiDotNet.Ndr.Marshal.NdrEnum16 p0, out int p1, out short[] p2, out short[] p3)
        {
            _Marshal_Helper m = new _Marshal_Helper();
            m.WriteEnum16(p0);
            _Unmarshal_Helper u = SendReceive(1, m);
            p1 = u.ReadInt32();
            p2 = u.ReadReferent<short[]>(new System.Func<short[]>(u.Read_0), false);
            p3 = u.ReadReferent<short[]>(new System.Func<short[]>(u.Read_0), false);
            return u.ReadInt32();
        }
    }
    #endregion
}

