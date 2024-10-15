// Decompiled with JetBrains decompiler
// Type: SRPG.ReqMultiPlayResume
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x2003108")]
  public class ReqMultiPlayResume : WebAPI
  {
    [Token(Token = "0x600DD9B")]
    [Address(RVA = "0xA888A0", Offset = "0xA876A0", VA = "0x10A888A0")]
    public ReqMultiPlayResume(long btlID, Network.ResponseCallback response)
    {
    }

    [Token(Token = "0x2003109")]
    public class Quest
    {
      [Token(Token = "0x400EC72")]
      [FieldOffset(Offset = "0x8")]
      public string iname;

      [Token(Token = "0x600DD9C")]
      [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
      public Quest()
      {
      }
    }

    [Token(Token = "0x200310A")]
    public class Response
    {
      [Token(Token = "0x400EC73")]
      [FieldOffset(Offset = "0x8")]
      public ReqMultiPlayResume.Quest quest;
      [Token(Token = "0x400EC74")]
      [FieldOffset(Offset = "0xC")]
      public int btlid;
      [Token(Token = "0x400EC75")]
      [FieldOffset(Offset = "0x10")]
      public string app_id;
      [Token(Token = "0x400EC76")]
      [FieldOffset(Offset = "0x14")]
      public string token;
      [Token(Token = "0x400EC77")]
      [FieldOffset(Offset = "0x18")]
      public Json_BtlInfo_Multi btlinfo;

      [Token(Token = "0x600DD9D")]
      [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
      public Response()
      {
      }
    }
  }
}
