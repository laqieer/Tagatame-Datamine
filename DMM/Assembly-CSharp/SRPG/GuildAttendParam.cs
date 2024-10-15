// Decompiled with JetBrains decompiler
// Type: SRPG.GuildAttendParam
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x2001B23")]
  public class GuildAttendParam
  {
    [Token(Token = "0x400676D")]
    [FieldOffset(Offset = "0x8")]
    private int mID;
    [Token(Token = "0x400676E")]
    [FieldOffset(Offset = "0x10")]
    private long mStartAt;
    [Token(Token = "0x400676F")]
    [FieldOffset(Offset = "0x18")]
    private long mEndAt;
    [Token(Token = "0x4006770")]
    [FieldOffset(Offset = "0x20")]
    private GuildAttendRewardDetail[] mRewards;

    [Token(Token = "0x17000D10")]
    public int id
    {
      [Token(Token = "0x6006FE4"), Address(RVA = "0x28D5B0", Offset = "0x28C3B0", VA = "0x1028D5B0")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x17000D11")]
    public long start_at
    {
      [Token(Token = "0x6006FE5"), Address(RVA = "0x361230", Offset = "0x360030", VA = "0x10361230")] get
      {
        return new long();
      }
    }

    [Token(Token = "0x17000D12")]
    public long end_at
    {
      [Token(Token = "0x6006FE6"), Address(RVA = "0x34F480", Offset = "0x34E280", VA = "0x1034F480")] get
      {
        return new long();
      }
    }

    [Token(Token = "0x17000D13")]
    public GuildAttendRewardDetail[] rewards
    {
      [Token(Token = "0x6006FE7"), Address(RVA = "0x2880C0", Offset = "0x286EC0", VA = "0x102880C0")] get
      {
        return (GuildAttendRewardDetail[]) null;
      }
    }

    [Token(Token = "0x6006FE8")]
    [Address(RVA = "0x36E640", Offset = "0x36D440", VA = "0x1036E640")]
    public static bool Deserialize(ref GuildAttendParam[] param, JSON_GuildAttendParam[] json)
    {
      return new bool();
    }

    [Token(Token = "0x6006FE9")]
    [Address(RVA = "0x36E3D0", Offset = "0x36D1D0", VA = "0x1036E3D0")]
    public void Deserialize(JSON_GuildAttendParam json)
    {
    }

    [Token(Token = "0x6006FEA")]
    [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
    public GuildAttendParam()
    {
    }
  }
}
