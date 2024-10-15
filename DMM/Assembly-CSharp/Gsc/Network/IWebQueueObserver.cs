// Decompiled with JetBrains decompiler
// Type: Gsc.Network.IWebQueueObserver
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;

#nullable disable
namespace Gsc.Network
{
  [Token(Token = "0x2003560")]
  public interface IWebQueueObserver
  {
    [Token(Token = "0x600EC86")]
    void OnStart();

    [Token(Token = "0x600EC87")]
    void OnFinish();

    [Token(Token = "0x600EC88")]
    void OnReceiveUnhandledTasks(WebTaskBundle taskBundle);

    [Token(Token = "0x600EC89")]
    void Reset();
  }
}
