// Decompiled with JetBrains decompiler
// Type: SRPG.VersusScheduleParam
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x2001EDF")]
  public class VersusScheduleParam
  {
    [Token(Token = "0x40081D3")]
    [FieldOffset(Offset = "0x8")]
    public string tower_iname;
    [Token(Token = "0x40081D4")]
    [FieldOffset(Offset = "0xC")]
    public string iname;
    [Token(Token = "0x40081D5")]
    [FieldOffset(Offset = "0x10")]
    public string begin_at;
    [Token(Token = "0x40081D6")]
    [FieldOffset(Offset = "0x14")]
    public string end_at;
    [Token(Token = "0x40081D7")]
    [FieldOffset(Offset = "0x18")]
    public string gift_begin_at;
    [Token(Token = "0x40081D8")]
    [FieldOffset(Offset = "0x1C")]
    public string gift_end_at;
    [Token(Token = "0x40081D9")]
    [FieldOffset(Offset = "0x20")]
    private DateTime BeginDate;
    [Token(Token = "0x40081DA")]
    [FieldOffset(Offset = "0x28")]
    private DateTime EndDate;
    [Token(Token = "0x40081DB")]
    [FieldOffset(Offset = "0x30")]
    private DateTime GiftBeginDate;
    [Token(Token = "0x40081DC")]
    [FieldOffset(Offset = "0x38")]
    private DateTime GiftEndDate;

    [Token(Token = "0x170011D1")]
    public bool IsOpen
    {
      [Token(Token = "0x6007E44"), Address(RVA = "0x3FBAA0", Offset = "0x3FA8A0", VA = "0x103FBAA0")] get
      {
        return new bool();
      }
    }

    [Token(Token = "0x170011D2")]
    public bool IsGift
    {
      [Token(Token = "0x6007E45"), Address(RVA = "0x3FB9D0", Offset = "0x3FA7D0", VA = "0x103FB9D0")] get
      {
        return new bool();
      }
    }

    [Token(Token = "0x6007E46")]
    [Address(RVA = "0x3FB830", Offset = "0x3FA630", VA = "0x103FB830")]
    public void Deserialize(JSON_VersusSchedule json)
    {
    }

    [Token(Token = "0x6007E47")]
    [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
    public VersusScheduleParam()
    {
    }
  }
}
