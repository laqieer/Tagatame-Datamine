// Decompiled with JetBrains decompiler
// Type: SRPG.EventShopListItemArena
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x2002397")]
  [AddComponentMenu("UI/EventShopListItemArena")]
  public class EventShopListItemArena : MonoBehaviour
  {
    [Token(Token = "0x400A079")]
    [FieldOffset(Offset = "0xC")]
    public GameObject mLockObject;
    [Token(Token = "0x400A07A")]
    [FieldOffset(Offset = "0x10")]
    public Text mLockText;

    [Token(Token = "0x60099DA")]
    [Address(RVA = "0x5E0A20", Offset = "0x5DF820", VA = "0x105E0A20")]
    private void Start()
    {
    }

    [Token(Token = "0x60099DB")]
    [Address(RVA = "0x2ACF80", Offset = "0x2ABD80", VA = "0x102ACF80")]
    public EventShopListItemArena()
    {
    }
  }
}
