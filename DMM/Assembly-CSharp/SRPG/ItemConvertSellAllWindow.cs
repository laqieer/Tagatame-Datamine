// Decompiled with JetBrains decompiler
// Type: SRPG.ItemConvertSellAllWindow
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x2002655")]
  [AddComponentMenu("UI/ItemConvertSellAllWindow")]
  public class ItemConvertSellAllWindow : MonoBehaviour
  {
    [Token(Token = "0x400B33A")]
    [FieldOffset(Offset = "0xC")]
    public Transform ItemLayout;
    [Token(Token = "0x400B33B")]
    [FieldOffset(Offset = "0x10")]
    public GameObject ItemTemplate;
    [Token(Token = "0x400B33C")]
    [FieldOffset(Offset = "0x14")]
    public Text ConvertItemName;
    [Token(Token = "0x400B33D")]
    [FieldOffset(Offset = "0x18")]
    public Text ConvertItemNum;
    [Token(Token = "0x400B33E")]
    [FieldOffset(Offset = "0x1C")]
    public Text ConvertResult;
    [Token(Token = "0x400B33F")]
    [FieldOffset(Offset = "0x20")]
    public GameObject RemainItemObject;
    [Token(Token = "0x400B340")]
    [FieldOffset(Offset = "0x0")]
    public static ItemConvertSellAllWindow mInstance;

    [Token(Token = "0x170017F4")]
    public static ItemConvertSellAllWindow Instance
    {
      [Token(Token = "0x600AB25"), Address(RVA = "0x6E53C0", Offset = "0x6E41C0", VA = "0x106E53C0")] get
      {
        return (ItemConvertSellAllWindow) null;
      }
    }

    [Token(Token = "0x600AB26")]
    [Address(RVA = "0x6E4F40", Offset = "0x6E3D40", VA = "0x106E4F40")]
    private void Awake()
    {
    }

    [Token(Token = "0x600AB27")]
    [Address(RVA = "0x6E4F80", Offset = "0x6E3D80", VA = "0x106E4F80")]
    private void OnDestroy()
    {
    }

    [Token(Token = "0x600AB28")]
    [Address(RVA = "0x6E52F0", Offset = "0x6E40F0", VA = "0x106E52F0")]
    private void Start()
    {
    }

    [Token(Token = "0x600AB29")]
    [Address(RVA = "0x6E4FC0", Offset = "0x6E3DC0", VA = "0x106E4FC0")]
    public void SetSellItemList(Json_ItemSellConvertList[] json, int remain)
    {
    }

    [Token(Token = "0x600AB2A")]
    [Address(RVA = "0x2ACF80", Offset = "0x2ABD80", VA = "0x102ACF80")]
    public ItemConvertSellAllWindow()
    {
    }
  }
}
