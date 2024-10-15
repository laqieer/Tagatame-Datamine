// Decompiled with JetBrains decompiler
// Type: SRPG.JSON_AppealEventMaster
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x2001FBC")]
  public class JSON_AppealEventMaster
  {
    [Token(Token = "0x4008676")]
    [FieldOffset(Offset = "0x8")]
    public int pk;
    [Token(Token = "0x4008677")]
    [FieldOffset(Offset = "0xC")]
    public JSON_AppealEventMaster.Fields fields;

    [Token(Token = "0x60082C4")]
    [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
    public JSON_AppealEventMaster()
    {
    }

    [Token(Token = "0x2001FBD")]
    public class Fields
    {
      [Token(Token = "0x4008678")]
      [FieldOffset(Offset = "0x8")]
      public string appeal_id;
      [Token(Token = "0x4008679")]
      [FieldOffset(Offset = "0xC")]
      public string start_at;
      [Token(Token = "0x400867A")]
      [FieldOffset(Offset = "0x10")]
      public string end_at;

      [Token(Token = "0x60082C5")]
      [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
      public Fields()
      {
      }
    }
  }
}
