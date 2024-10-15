// Decompiled with JetBrains decompiler
// Type: SRPG.LimitedShopLock
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x20026D8")]
  [RequireComponent(typeof (Selectable))]
  [AddComponentMenu("UI/LimitedShopLock")]
  public class LimitedShopLock : MonoBehaviour
  {
    [Token(Token = "0x400B698")]
    [FieldOffset(Offset = "0xC")]
    [SerializeField]
    private GameObject LockObject;
    [Token(Token = "0x400B699")]
    [FieldOffset(Offset = "0x10")]
    private Button mButton;

    [Token(Token = "0x600ADEB")]
    [Address(RVA = "0x71F3A0", Offset = "0x71E1A0", VA = "0x1071F3A0")]
    private void Awake()
    {
    }

    [Token(Token = "0x600ADEC")]
    [Address(RVA = "0x71F420", Offset = "0x71E220", VA = "0x1071F420")]
    private void Start()
    {
    }

    [Token(Token = "0x600ADED")]
    [Address(RVA = "0x71F420", Offset = "0x71E220", VA = "0x1071F420")]
    private void UpdateLockState()
    {
    }

    [Token(Token = "0x600ADEE")]
    [Address(RVA = "0x2ACF80", Offset = "0x2ABD80", VA = "0x102ACF80")]
    public LimitedShopLock()
    {
    }
  }
}
