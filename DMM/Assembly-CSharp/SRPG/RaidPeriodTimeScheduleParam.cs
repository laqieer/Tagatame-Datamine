// Decompiled with JetBrains decompiler
// Type: SRPG.RaidPeriodTimeScheduleParam
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using MessagePack;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x2001C83")]
  [MessagePackObject(true)]
  public class RaidPeriodTimeScheduleParam
  {
    [Token(Token = "0x4007007")]
    [FieldOffset(Offset = "0x8")]
    private string mBegin;
    [Token(Token = "0x4007008")]
    [FieldOffset(Offset = "0xC")]
    private string mOpen;

    [Token(Token = "0x17000F2D")]
    public string Begin
    {
      [Token(Token = "0x6007593"), Address(RVA = "0x28D5B0", Offset = "0x28C3B0", VA = "0x1028D5B0")] get
      {
        return (string) null;
      }
    }

    [Token(Token = "0x17000F2E")]
    public string Open
    {
      [Token(Token = "0x6007594"), Address(RVA = "0x28D5A0", Offset = "0x28C3A0", VA = "0x1028D5A0")] get
      {
        return (string) null;
      }
    }

    [Token(Token = "0x6007595")]
    [Address(RVA = "0x362350", Offset = "0x361150", VA = "0x10362350")]
    public bool Deserialize(JSON_RaidPeriodTimeScheduleParam json) => new bool();

    [Token(Token = "0x6007596")]
    [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
    public RaidPeriodTimeScheduleParam()
    {
    }
  }
}
