// Decompiled with JetBrains decompiler
// Type: SRPG.VersusRankMissionScheduleParam
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x2001ED2")]
  public class VersusRankMissionScheduleParam
  {
    [Token(Token = "0x4008198")]
    [FieldOffset(Offset = "0x8")]
    private int mScheduleId;
    [Token(Token = "0x4008199")]
    [FieldOffset(Offset = "0xC")]
    private string mIName;

    [Token(Token = "0x170011BE")]
    public int ScheduleId
    {
      [Token(Token = "0x6007E1E"), Address(RVA = "0x28D5B0", Offset = "0x28C3B0", VA = "0x1028D5B0")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x170011BF")]
    public string IName
    {
      [Token(Token = "0x6007E1F"), Address(RVA = "0x28D5A0", Offset = "0x28C3A0", VA = "0x1028D5A0")] get
      {
        return (string) null;
      }
    }

    [Token(Token = "0x6007E20")]
    [Address(RVA = "0x35F6F0", Offset = "0x35E4F0", VA = "0x1035F6F0")]
    public bool Deserialize(JSON_VersusRankMissionScheduleParam json) => new bool();

    [Token(Token = "0x6007E21")]
    [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
    public VersusRankMissionScheduleParam()
    {
    }
  }
}
