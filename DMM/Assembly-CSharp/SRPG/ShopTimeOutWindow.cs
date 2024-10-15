// Decompiled with JetBrains decompiler
// Type: SRPG.ShopTimeOutWindow
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System.Collections.Generic;
using UnityEngine;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x2002AB5")]
  [AddComponentMenu("UI/ShopTimeOutWindow")]
  public class ShopTimeOutWindow : MonoBehaviour
  {
    [Token(Token = "0x400D059")]
    [FieldOffset(Offset = "0xC")]
    [SerializeField]
    private GameObject ItemParent;
    [Token(Token = "0x400D05A")]
    [FieldOffset(Offset = "0x10")]
    [SerializeField]
    private GameObject ItemTemplate;
    [Token(Token = "0x400D05B")]
    [FieldOffset(Offset = "0x14")]
    private List<GameObject> mItems;

    [Token(Token = "0x600C310")]
    [Address(RVA = "0x8B77B0", Offset = "0x8B65B0", VA = "0x108B77B0")]
    private void Start()
    {
    }

    [Token(Token = "0x600C311")]
    [Address(RVA = "0x8B71B0", Offset = "0x8B5FB0", VA = "0x108B71B0")]
    private void Refresh()
    {
    }

    [Token(Token = "0x600C312")]
    public GameObject InstantiateItem<BindType>(
      GameObject template,
      Transform parent,
      BindType item)
    {
      return (GameObject) null;
    }

    [Token(Token = "0x600C313")]
    [Address(RVA = "0x8B7830", Offset = "0x8B6630", VA = "0x108B7830")]
    public ShopTimeOutWindow()
    {
    }
  }
}
