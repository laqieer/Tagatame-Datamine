// Decompiled with JetBrains decompiler
// Type: SRPG.ReqVersusStart
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x2003117")]
  public class ReqVersusStart : WebAPI
  {
    [Token(Token = "0x600DDAC")]
    [Address(RVA = "0xA8F550", Offset = "0xA8E350", VA = "0x10A8F550")]
    public ReqVersusStart(Network.ResponseCallback response)
    {
    }

    [Token(Token = "0x2003118")]
    public class JSON_VersusMap
    {
      [Token(Token = "0x400EC85")]
      [FieldOffset(Offset = "0x8")]
      public string free;
      [Token(Token = "0x400EC86")]
      [FieldOffset(Offset = "0xC")]
      public string tower;
      [Token(Token = "0x400EC87")]
      [FieldOffset(Offset = "0x10")]
      public string friend;

      [Token(Token = "0x600DDAD")]
      [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
      public JSON_VersusMap()
      {
      }
    }

    [Token(Token = "0x2003119")]
    public class Response
    {
      [Token(Token = "0x400EC88")]
      [FieldOffset(Offset = "0x8")]
      public string app_id;
      [Token(Token = "0x400EC89")]
      [FieldOffset(Offset = "0xC")]
      public ReqVersusStart.JSON_VersusMap maps;
      [Token(Token = "0x400EC8A")]
      [FieldOffset(Offset = "0x10")]
      public string btl_ver;

      [Token(Token = "0x600DDAE")]
      [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
      public Response()
      {
      }
    }
  }
}
