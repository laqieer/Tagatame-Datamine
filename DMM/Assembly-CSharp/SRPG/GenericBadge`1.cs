// Decompiled with JetBrains decompiler
// Type: SRPG.GenericBadge`1
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x200201E")]
  internal class GenericBadge<T> where T : class
  {
    [Token(Token = "0x400893F")]
    [FieldOffset(Offset = "0x0")]
    public bool mValue;
    [Token(Token = "0x4008940")]
    [FieldOffset(Offset = "0x0")]
    public T mRawData;

    [Token(Token = "0x60084E1")]
    public GenericBadge(T data, bool value = false)
    {
    }
  }
}
