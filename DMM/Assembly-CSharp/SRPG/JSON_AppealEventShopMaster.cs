// Decompiled with JetBrains decompiler
// Type: SRPG.JSON_AppealEventShopMaster
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x2001FC1")]
  public class JSON_AppealEventShopMaster
  {
    [Token(Token = "0x4008696")]
    [FieldOffset(Offset = "0x8")]
    public JSON_AppealEventShopMaster.Fields fields;

    [Token(Token = "0x60082D6")]
    [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
    public JSON_AppealEventShopMaster()
    {
    }

    [Token(Token = "0x2001FC2")]
    public class Fields
    {
      [Token(Token = "0x4008697")]
      [FieldOffset(Offset = "0x8")]
      public string appeal_id;
      [Token(Token = "0x4008698")]
      [FieldOffset(Offset = "0xC")]
      public string start_at;
      [Token(Token = "0x4008699")]
      [FieldOffset(Offset = "0x10")]
      public string end_at;
      [Token(Token = "0x400869A")]
      [FieldOffset(Offset = "0x14")]
      public int priority;
      [Token(Token = "0x400869B")]
      [FieldOffset(Offset = "0x18")]
      public float position_chara;
      [Token(Token = "0x400869C")]
      [FieldOffset(Offset = "0x1C")]
      public float position_text;

      [Token(Token = "0x60082D7")]
      [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
      public Fields()
      {
      }
    }
  }
}
