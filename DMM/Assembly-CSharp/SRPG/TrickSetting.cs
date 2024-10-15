// Decompiled with JetBrains decompiler
// Type: SRPG.TrickSetting
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x2000C22")]
  public class TrickSetting
  {
    [Token(Token = "0x4001F96")]
    [FieldOffset(Offset = "0x8")]
    public string mId;
    [Token(Token = "0x4001F97")]
    [FieldOffset(Offset = "0xC")]
    public OInt mGx;
    [Token(Token = "0x4001F98")]
    [FieldOffset(Offset = "0x20")]
    public OInt mGy;
    [Token(Token = "0x4001F99")]
    [FieldOffset(Offset = "0x34")]
    public string mTag;

    [Token(Token = "0x6003036")]
    [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
    public TrickSetting()
    {
    }

    [Token(Token = "0x6003037")]
    [Address(RVA = "0xFEB890", Offset = "0xFEA690", VA = "0x10FEB890")]
    public TrickSetting(JSON_MapTrick json)
    {
    }
  }
}
