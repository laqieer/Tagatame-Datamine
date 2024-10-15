// Decompiled with JetBrains decompiler
// Type: SRPG.TimeRecoveryValue
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x2001053")]
  public class TimeRecoveryValue
  {
    [Token(Token = "0x4003A3A")]
    [FieldOffset(Offset = "0x8")]
    public OInt val;
    [Token(Token = "0x4003A3B")]
    [FieldOffset(Offset = "0x1C")]
    public OInt valMax;
    [Token(Token = "0x4003A3C")]
    [FieldOffset(Offset = "0x30")]
    public OInt valRecover;
    [Token(Token = "0x4003A3D")]
    [FieldOffset(Offset = "0x48")]
    public OLong interval;
    [Token(Token = "0x4003A3E")]
    [FieldOffset(Offset = "0x70")]
    public OLong at;
    [Token(Token = "0x4003A3F")]
    [FieldOffset(Offset = "0x98")]
    private float lastUpdateTime;

    [Token(Token = "0x6004304")]
    [Address(RVA = "0x11EA400", Offset = "0x11E9200", VA = "0x111EA400")]
    public void Update()
    {
    }

    [Token(Token = "0x6004305")]
    [Address(RVA = "0x11EA190", Offset = "0x11E8F90", VA = "0x111EA190")]
    public long GetNextRecoverySec() => new long();

    [Token(Token = "0x6004306")]
    [Address(RVA = "0x11EA320", Offset = "0x11E9120", VA = "0x111EA320")]
    public void SubValue(int subval)
    {
    }

    [Token(Token = "0x6004307")]
    [Address(RVA = "0x11EA650", Offset = "0x11E9450", VA = "0x111EA650")]
    public TimeRecoveryValue()
    {
    }
  }
}
