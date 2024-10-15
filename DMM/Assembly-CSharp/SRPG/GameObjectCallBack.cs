// Decompiled with JetBrains decompiler
// Type: SRPG.GameObjectCallBack
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.Events;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x20024D2")]
  [AddComponentMenu("UI/GameObjectCallBack")]
  public class GameObjectCallBack : MonoBehaviour
  {
    [Token(Token = "0x400A82E")]
    [FieldOffset(Offset = "0xC")]
    private UnityEvent mOnDestroy;
    [Token(Token = "0x400A82F")]
    [FieldOffset(Offset = "0x10")]
    private UnityEvent mOnEnable;
    [Token(Token = "0x400A830")]
    [FieldOffset(Offset = "0x14")]
    private UnityEvent mOnDisable;
    [Token(Token = "0x400A831")]
    [FieldOffset(Offset = "0x18")]
    private UnityEvent mOnStart;

    [Token(Token = "0x17001691")]
    public UnityEvent onDestroy
    {
      [Token(Token = "0x600A190"), Address(RVA = "0x28D5A0", Offset = "0x28C3A0", VA = "0x1028D5A0")] get
      {
        return (UnityEvent) null;
      }
    }

    [Token(Token = "0x17001692")]
    public UnityEvent onEnable
    {
      [Token(Token = "0x600A191"), Address(RVA = "0x29EEB0", Offset = "0x29DCB0", VA = "0x1029EEB0")] get
      {
        return (UnityEvent) null;
      }
    }

    [Token(Token = "0x17001693")]
    public UnityEvent onDisable
    {
      [Token(Token = "0x600A192"), Address(RVA = "0x2BAA70", Offset = "0x2B9870", VA = "0x102BAA70")] get
      {
        return (UnityEvent) null;
      }
    }

    [Token(Token = "0x17001694")]
    public UnityEvent onStart
    {
      [Token(Token = "0x600A193"), Address(RVA = "0x26E190", Offset = "0x26CF90", VA = "0x1026E190")] get
      {
        return (UnityEvent) null;
      }
    }

    [Token(Token = "0x600A194")]
    [Address(RVA = "0x2781C0", Offset = "0x276FC0", VA = "0x102781C0")]
    private void Awake()
    {
    }

    [Token(Token = "0x600A195")]
    [Address(RVA = "0x638920", Offset = "0x637720", VA = "0x10638920")]
    private void Start()
    {
    }

    [Token(Token = "0x600A196")]
    [Address(RVA = "0x638900", Offset = "0x637700", VA = "0x10638900")]
    private void OnEnable()
    {
    }

    [Token(Token = "0x600A197")]
    [Address(RVA = "0x6388E0", Offset = "0x6376E0", VA = "0x106388E0")]
    private void OnDisable()
    {
    }

    [Token(Token = "0x600A198")]
    [Address(RVA = "0x638870", Offset = "0x637670", VA = "0x10638870")]
    private void OnDestroy()
    {
    }

    [Token(Token = "0x600A199")]
    [Address(RVA = "0x638810", Offset = "0x637610", VA = "0x10638810")]
    private void OnApplicationQuit()
    {
    }

    [Token(Token = "0x600A19A")]
    [Address(RVA = "0x638940", Offset = "0x637740", VA = "0x10638940")]
    public GameObjectCallBack()
    {
    }
  }
}
