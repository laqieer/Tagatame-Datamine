// Decompiled with JetBrains decompiler
// Type: GR.MonoSingleton`1
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using UnityEngine;

#nullable disable
namespace GR
{
  [Token(Token = "0x200032D")]
  public abstract class MonoSingleton<T> : MonoBehaviour where T : MonoBehaviour
  {
    [Token(Token = "0x4000CFA")]
    [FieldOffset(Offset = "0x0")]
    private static T instance_;
    [Token(Token = "0x4000CFB")]
    [FieldOffset(Offset = "0x0")]
    private static bool mIsShuttingDown;
    [Token(Token = "0x4000CFC")]
    [FieldOffset(Offset = "0x0")]
    private static bool mDestroyedBySystem;

    [Token(Token = "0x170001EB")]
    public static T Instance
    {
      [Token(Token = "0x6001109")] get => (T) null;
    }

    [Token(Token = "0x600110A")]
    public static T GetInstanceDirect() => (T) null;

    [Token(Token = "0x600110B")]
    public static T GetInstanceIfInitialized() => (T) null;

    [Token(Token = "0x600110C")]
    private void Awake()
    {
    }

    [Token(Token = "0x600110D")]
    protected virtual void Initialize()
    {
    }

    [Token(Token = "0x600110E")]
    protected virtual void Release()
    {
    }

    [Token(Token = "0x600110F")]
    private void OnDestroy()
    {
    }

    [Token(Token = "0x6001110")]
    private void OnApplicationQuit()
    {
    }

    [Token(Token = "0x6001111")]
    public void Ensure()
    {
    }

    [Token(Token = "0x6001112")]
    protected MonoSingleton()
    {
    }
  }
}
