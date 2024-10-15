// Decompiled with JetBrains decompiler
// Type: SRPG.ReqLimitedShopList
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x2003185")]
  public class ReqLimitedShopList : WebAPI
  {
    [Token(Token = "0x600DE18")]
    [Address(RVA = "0xA9AE50", Offset = "0xA99C50", VA = "0x10A9AE50")]
    public ReqLimitedShopList(
      Network.ResponseCallback response,
      ReqLimitedShopList.eShopType shop_type = ReqLimitedShopList.eShopType.Limited)
    {
    }

    [Token(Token = "0x2003186")]
    public enum eShopType
    {
      [Token(Token = "0x400ED4B")] Limited,
      [Token(Token = "0x400ED4C")] Port,
    }
  }
}
