// Decompiled with JetBrains decompiler
// Type: SRPG.WeatherParam
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System.Collections.Generic;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x2001EF2")]
  public class WeatherParam
  {
    [Token(Token = "0x4008241")]
    [FieldOffset(Offset = "0x8")]
    private string mIname;
    [Token(Token = "0x4008242")]
    [FieldOffset(Offset = "0xC")]
    private string mName;
    [Token(Token = "0x4008243")]
    [FieldOffset(Offset = "0x10")]
    private string mExpr;
    [Token(Token = "0x4008244")]
    [FieldOffset(Offset = "0x14")]
    private string mIcon;
    [Token(Token = "0x4008245")]
    [FieldOffset(Offset = "0x18")]
    private string mEffect;
    [Token(Token = "0x4008246")]
    [FieldOffset(Offset = "0x1C")]
    private int mChangeClock;
    [Token(Token = "0x4008247")]
    [FieldOffset(Offset = "0x20")]
    private bool mIsUnitDeadDelete;
    [Token(Token = "0x4008248")]
    [FieldOffset(Offset = "0x21")]
    private bool mIsNotOverWrite;
    [Token(Token = "0x4008249")]
    [FieldOffset(Offset = "0x24")]
    private List<WeatherDetailParam> mDetails;

    [Token(Token = "0x170011E2")]
    public string Iname
    {
      [Token(Token = "0x6007E72"), Address(RVA = "0x28D5B0", Offset = "0x28C3B0", VA = "0x1028D5B0")] get
      {
        return (string) null;
      }
    }

    [Token(Token = "0x170011E3")]
    public string Name
    {
      [Token(Token = "0x6007E73"), Address(RVA = "0x28D5A0", Offset = "0x28C3A0", VA = "0x1028D5A0")] get
      {
        return (string) null;
      }
    }

    [Token(Token = "0x170011E4")]
    public string Expr
    {
      [Token(Token = "0x6007E74"), Address(RVA = "0x29EEB0", Offset = "0x29DCB0", VA = "0x1029EEB0")] get
      {
        return (string) null;
      }
    }

    [Token(Token = "0x170011E5")]
    public string Icon
    {
      [Token(Token = "0x6007E75"), Address(RVA = "0x2BAA70", Offset = "0x2B9870", VA = "0x102BAA70")] get
      {
        return (string) null;
      }
    }

    [Token(Token = "0x170011E6")]
    public string Effect
    {
      [Token(Token = "0x6007E76"), Address(RVA = "0x26E190", Offset = "0x26CF90", VA = "0x1026E190")] get
      {
        return (string) null;
      }
    }

    [Token(Token = "0x170011E7")]
    public int ChangeClock
    {
      [Token(Token = "0x6007E77"), Address(RVA = "0x2700B0", Offset = "0x26EEB0", VA = "0x102700B0")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x170011E8")]
    public bool IsUnitDeadDelete
    {
      [Token(Token = "0x6007E78"), Address(RVA = "0x305F30", Offset = "0x304D30", VA = "0x10305F30")] get
      {
        return new bool();
      }
    }

    [Token(Token = "0x170011E9")]
    public bool IsNotOverWrite
    {
      [Token(Token = "0x6007E79"), Address(RVA = "0x305F20", Offset = "0x304D20", VA = "0x10305F20")] get
      {
        return new bool();
      }
    }

    [Token(Token = "0x170011EA")]
    public List<WeatherDetailParam> Details
    {
      [Token(Token = "0x6007E7A"), Address(RVA = "0x29E830", Offset = "0x29D630", VA = "0x1029E830")] get
      {
        return (List<WeatherDetailParam>) null;
      }
    }

    [Token(Token = "0x6007E7B")]
    [Address(RVA = "0x3FE2A0", Offset = "0x3FD0A0", VA = "0x103FE2A0")]
    public void Deserialize(JSON_WeatherParam json)
    {
    }

    [Token(Token = "0x6007E7C")]
    [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
    public WeatherParam()
    {
    }
  }
}
