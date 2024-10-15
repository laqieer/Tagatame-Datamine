// Decompiled with JetBrains decompiler
// Type: SRPG.ReqVersusResume
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x200314C")]
  public class ReqVersusResume : WebAPI
  {
    [Token(Token = "0x600DDE2")]
    [Address(RVA = "0xA8F190", Offset = "0xA8DF90", VA = "0x10A8F190")]
    public ReqVersusResume(long btlID, Network.ResponseCallback response)
    {
    }

    [Token(Token = "0x200314D")]
    public class Quest
    {
      [Token(Token = "0x400ED05")]
      [FieldOffset(Offset = "0x8")]
      public string iname;

      [Token(Token = "0x600DDE3")]
      [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
      public Quest()
      {
      }
    }

    [Token(Token = "0x200314E")]
    public class Response
    {
      [Token(Token = "0x400ED06")]
      [FieldOffset(Offset = "0x8")]
      public ReqVersusResume.Quest quest;
      [Token(Token = "0x400ED07")]
      [FieldOffset(Offset = "0xC")]
      public int btlid;
      [Token(Token = "0x400ED08")]
      [FieldOffset(Offset = "0x10")]
      public string app_id;
      [Token(Token = "0x400ED09")]
      [FieldOffset(Offset = "0x14")]
      public string token;
      [Token(Token = "0x400ED0A")]
      [FieldOffset(Offset = "0x18")]
      public string type;
      [Token(Token = "0x400ED0B")]
      [FieldOffset(Offset = "0x1C")]
      public Json_BtlInfo_Multi btlinfo;

      [Token(Token = "0x600DDE4")]
      [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
      public Response()
      {
      }
    }
  }
}
