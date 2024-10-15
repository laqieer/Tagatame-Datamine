// Decompiled with JetBrains decompiler
// Type: MessagePack.IMessagePackSerializationCallbackReceiver
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;

#nullable disable
namespace MessagePack
{
  [Token(Token = "0x2000351")]
  public interface IMessagePackSerializationCallbackReceiver
  {
    [Token(Token = "0x6001191")]
    void OnBeforeSerialize();

    [Token(Token = "0x6001192")]
    void OnAfterDeserialize();
  }
}
