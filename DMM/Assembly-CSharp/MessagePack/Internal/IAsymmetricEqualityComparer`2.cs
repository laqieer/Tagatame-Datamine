// Decompiled with JetBrains decompiler
// Type: MessagePack.Internal.IAsymmetricEqualityComparer`2
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;

#nullable disable
namespace MessagePack.Internal
{
  [Token(Token = "0x200045A")]
  internal interface IAsymmetricEqualityComparer<TKey1, TKey2>
  {
    [Token(Token = "0x600155B")]
    int GetHashCode(TKey1 key1);

    [Token(Token = "0x600155C")]
    int GetHashCode(TKey2 key2);

    [Token(Token = "0x600155D")]
    bool Equals(TKey1 x, TKey1 y);

    [Token(Token = "0x600155E")]
    bool Equals(TKey1 x, TKey2 y);
  }
}
