// Decompiled with JetBrains decompiler
// Type: Gsc.Network.IErrorResponse
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Gsc.DOM;
using Il2CppDummyDll;

#nullable disable
namespace Gsc.Network
{
  [Token(Token = "0x200355F")]
  public interface IErrorResponse : IResponse
  {
    [Token(Token = "0x170021D9")]
    IDocument data { [Token(Token = "0x600EC84")] get; }

    [Token(Token = "0x170021DA")]
    string ErrorCode { [Token(Token = "0x600EC85")] get; }
  }
}
