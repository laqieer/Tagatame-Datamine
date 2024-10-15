// Decompiled with JetBrains decompiler
// Type: GR.Singleton`1
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;

#nullable disable
namespace GR
{
  [Token(Token = "0x200032F")]
  public abstract class Singleton<T> where T : class, new()
  {
    [Token(Token = "0x4000CFF")]
    [FieldOffset(Offset = "0x0")]
    private static T instance_;

    [Token(Token = "0x170001EC")]
    public static T Instance
    {
      [Token(Token = "0x600111A")] get => (T) null;
    }

    [Token(Token = "0x600111B")]
    protected Singleton()
    {
    }
  }
}
