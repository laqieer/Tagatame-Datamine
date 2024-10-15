// Decompiled with JetBrains decompiler
// Type: SRPG.ReqMultiTwResume
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x200316F")]
  public class ReqMultiTwResume : WebAPI
  {
    [Token(Token = "0x600DE05")]
    [Address(RVA = "0xA9B4C0", Offset = "0xA9A2C0", VA = "0x10A9B4C0")]
    public ReqMultiTwResume(long btlID, Network.ResponseCallback response)
    {
    }

    [Token(Token = "0x2003170")]
    public class Quest
    {
      [Token(Token = "0x400ED37")]
      [FieldOffset(Offset = "0x8")]
      public string iname;

      [Token(Token = "0x600DE06")]
      [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
      public Quest()
      {
      }
    }

    [Token(Token = "0x2003171")]
    public class Response
    {
      [Token(Token = "0x400ED38")]
      [FieldOffset(Offset = "0x8")]
      public int btlid;
      [Token(Token = "0x400ED39")]
      [FieldOffset(Offset = "0xC")]
      public string app_id;
      [Token(Token = "0x400ED3A")]
      [FieldOffset(Offset = "0x10")]
      public string token;
      [Token(Token = "0x400ED3B")]
      [FieldOffset(Offset = "0x14")]
      public string type;
      [Token(Token = "0x400ED3C")]
      [FieldOffset(Offset = "0x18")]
      public Json_BtlInfo_Multi btlinfo;

      [Token(Token = "0x600DE07")]
      [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
      public Response()
      {
      }
    }
  }
}
