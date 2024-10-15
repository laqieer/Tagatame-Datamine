// Decompiled with JetBrains decompiler
// Type: SRPG.JSON_AppealQuestMaster
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x2001FD1")]
  public class JSON_AppealQuestMaster
  {
    [Token(Token = "0x40086EE")]
    [FieldOffset(Offset = "0x8")]
    public JSON_AppealQuestMaster.Fields fields;

    [Token(Token = "0x600830E")]
    [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
    public JSON_AppealQuestMaster()
    {
    }

    [Token(Token = "0x2001FD2")]
    public class Fields
    {
      [Token(Token = "0x40086EF")]
      [FieldOffset(Offset = "0x8")]
      public string appeal_id;
      [Token(Token = "0x40086F0")]
      [FieldOffset(Offset = "0xC")]
      public string start_at;
      [Token(Token = "0x40086F1")]
      [FieldOffset(Offset = "0x10")]
      public string end_at;

      [Token(Token = "0x600830F")]
      [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
      public Fields()
      {
      }
    }
  }
}
