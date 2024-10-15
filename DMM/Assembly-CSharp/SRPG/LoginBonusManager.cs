// Decompiled with JetBrains decompiler
// Type: SRPG.LoginBonusManager
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System.Collections;
using UnityEngine;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x20026DC")]
  [FlowNode.Pin(100, "LoginBonusをCloseした", FlowNode.PinTypes.Output, 100)]
  [AddComponentMenu("UI/LoginBonus/LoginBonusManager")]
  public class LoginBonusManager : MonoBehaviour, IFlowInterface
  {
    [Token(Token = "0x400B6B1")]
    public const int PIN_OT_WINDOW_DESTROY = 100;
    [Token(Token = "0x400B6B2")]
    [FieldOffset(Offset = "0xC")]
    [StringIsResourcePath(typeof (GameObject))]
    [SerializeField]
    private string LoginBonusMonthPrefab;
    [Token(Token = "0x400B6B3")]
    [FieldOffset(Offset = "0x10")]
    [SerializeField]
    [StringIsResourcePath(typeof (GameObject))]
    private string TotalBonusPrefab;
    [Token(Token = "0x400B6B5")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    private Transform PrefabRoot;

    [Token(Token = "0x17001817")]
    public string TableID
    {
      [Token(Token = "0x600AE05"), Address(RVA = "0x2BAA70", Offset = "0x2B9870", VA = "0x102BAA70")] get
      {
        return (string) null;
      }
      [Token(Token = "0x600AE06"), Address(RVA = "0x34D340", Offset = "0x34C140", VA = "0x1034D340")] set
      {
      }
    }

    [Token(Token = "0x17001818")]
    public bool IsLoginCall
    {
      [Token(Token = "0x600AE07"), Address(RVA = "0x2A5AA0", Offset = "0x2A48A0", VA = "0x102A5AA0")] get
      {
        return new bool();
      }
      [Token(Token = "0x600AE08"), Address(RVA = "0x2A5AE0", Offset = "0x2A48E0", VA = "0x102A5AE0")] set
      {
      }
    }

    [Token(Token = "0x600AE09")]
    [Address(RVA = "0x2781C0", Offset = "0x276FC0", VA = "0x102781C0", Slot = "4")]
    public void Activated(int pinID)
    {
    }

    [Token(Token = "0x600AE0A")]
    [Address(RVA = "0x7211D0", Offset = "0x71FFD0", VA = "0x107211D0")]
    private void Awake()
    {
    }

    [Token(Token = "0x600AE0B")]
    [Address(RVA = "0x7212C0", Offset = "0x7200C0", VA = "0x107212C0")]
    private void Start()
    {
    }

    [Token(Token = "0x600AE0C")]
    [Address(RVA = "0x721250", Offset = "0x720050", VA = "0x10721250")]
    private IEnumerator LoadPrefab() => (IEnumerator) null;

    [Token(Token = "0x600AE0D")]
    [Address(RVA = "0x460550", Offset = "0x45F350", VA = "0x10460550")]
    private void OnDestroyLoginBonusWindow(GameObject obj)
    {
    }

    [Token(Token = "0x600AE0E")]
    [Address(RVA = "0x7213C0", Offset = "0x7201C0", VA = "0x107213C0")]
    public LoginBonusManager()
    {
    }
  }
}
