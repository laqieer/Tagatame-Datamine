// Decompiled with JetBrains decompiler
// Type: SRPG.ReqMonthlyRecover
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Gsc.Network.Encoding;
using Il2CppDummyDll;
using MessagePack;
using System;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x2003237")]
  public class ReqMonthlyRecover : WebAPI
  {
    [Token(Token = "0x600DED5")]
    [Address(RVA = "0xA9B0F0", Offset = "0xA99EF0", VA = "0x10A9B0F0")]
    public ReqMonthlyRecover(
      string select_iname,
      int select_dau,
      SRPG.Network.ResponseCallback response,
      EncodingTypes.ESerializeCompressMethod serializeCompressMethod)
    {
    }

    [Token(Token = "0x2003238")]
    [Serializable]
    public class RequestParam
    {
      [Token(Token = "0x400EE46")]
      [FieldOffset(Offset = "0x8")]
      public string iname;
      [Token(Token = "0x400EE47")]
      [FieldOffset(Offset = "0xC")]
      public int day;

      [Token(Token = "0x600DED6")]
      [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
      public RequestParam()
      {
      }
    }

    [Token(Token = "0x2003239")]
    [MessagePackObject(true)]
    [Serializable]
    public class Response
    {
      [Token(Token = "0x400EE48")]
      [FieldOffset(Offset = "0x8")]
      public Json_Notify_Monthly notify;

      [Token(Token = "0x600DED7")]
      [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
      public Response()
      {
      }
    }
  }
}
