// Decompiled with JetBrains decompiler
// Type: SRPG.JSON_AppealLimitedShopMaster
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x2001FCC")]
  public class JSON_AppealLimitedShopMaster
  {
    [Token(Token = "0x40086D1")]
    [FieldOffset(Offset = "0x8")]
    public int pk;
    [Token(Token = "0x40086D2")]
    [FieldOffset(Offset = "0xC")]
    public JSON_AppealLimitedShopMaster.Fields fields;

    [Token(Token = "0x60082FB")]
    [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
    public JSON_AppealLimitedShopMaster()
    {
    }

    [Token(Token = "0x2001FCD")]
    public class Fields
    {
      [Token(Token = "0x40086D3")]
      [FieldOffset(Offset = "0x8")]
      public string appeal_id;
      [Token(Token = "0x40086D4")]
      [FieldOffset(Offset = "0xC")]
      public string start_at;
      [Token(Token = "0x40086D5")]
      [FieldOffset(Offset = "0x10")]
      public string end_at;
      [Token(Token = "0x40086D6")]
      [FieldOffset(Offset = "0x14")]
      public int priority;
      [Token(Token = "0x40086D7")]
      [FieldOffset(Offset = "0x18")]
      public float position_chara;
      [Token(Token = "0x40086D8")]
      [FieldOffset(Offset = "0x1C")]
      public float position_text;

      [Token(Token = "0x60082FC")]
      [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
      public Fields()
      {
      }
    }
  }
}
