// Decompiled with JetBrains decompiler
// Type: SRPG.JSON_AppealGachaMaster
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x2001FC7")]
  public class JSON_AppealGachaMaster
  {
    [Token(Token = "0x40086AF")]
    [FieldOffset(Offset = "0x8")]
    public int pk;
    [Token(Token = "0x40086B0")]
    [FieldOffset(Offset = "0xC")]
    public JSON_AppealGachaMaster.Fields fields;

    [Token(Token = "0x60082E8")]
    [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
    public JSON_AppealGachaMaster()
    {
    }

    [Token(Token = "0x2001FC8")]
    public class Fields
    {
      [Token(Token = "0x40086B1")]
      [FieldOffset(Offset = "0x8")]
      public string appeal_id;
      [Token(Token = "0x40086B2")]
      [FieldOffset(Offset = "0xC")]
      public string start_at;
      [Token(Token = "0x40086B3")]
      [FieldOffset(Offset = "0x10")]
      public string end_at;
      [Token(Token = "0x40086B4")]
      [FieldOffset(Offset = "0x14")]
      public int flag_new;

      [Token(Token = "0x60082E9")]
      [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
      public Fields()
      {
      }
    }
  }
}
