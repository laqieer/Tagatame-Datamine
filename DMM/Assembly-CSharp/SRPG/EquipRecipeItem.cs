// Decompiled with JetBrains decompiler
// Type: SRPG.EquipRecipeItem
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x200235E")]
  [AddComponentMenu("UI/EquipRecipeItem")]
  public class EquipRecipeItem : MonoBehaviour
  {
    [Token(Token = "0x4009E80")]
    [FieldOffset(Offset = "0xC")]
    public Color DefaultLineColor;
    [Token(Token = "0x4009E81")]
    [FieldOffset(Offset = "0x1C")]
    public Color CommonEquipLineColor;
    [Token(Token = "0x4009E82")]
    [FieldOffset(Offset = "0x2C")]
    public Color DefaultTextColor;
    [Token(Token = "0x4009E83")]
    [FieldOffset(Offset = "0x3C")]
    public Color CommonEquipTextColor;
    [Token(Token = "0x4009E84")]
    [FieldOffset(Offset = "0x4C")]
    public Image[] Lines;
    [Token(Token = "0x4009E85")]
    [FieldOffset(Offset = "0x50")]
    public Text EquipItemNum;
    [Token(Token = "0x4009E86")]
    [FieldOffset(Offset = "0x54")]
    public GameObject CommonText;
    [Token(Token = "0x4009E87")]
    [FieldOffset(Offset = "0x58")]
    public GameObject CommonIcon;

    [Token(Token = "0x6009871")]
    [Address(RVA = "0x2781C0", Offset = "0x276FC0", VA = "0x102781C0")]
    private void Start()
    {
    }

    [Token(Token = "0x6009872")]
    [Address(RVA = "0x5B08A0", Offset = "0x5AF6A0", VA = "0x105B08A0")]
    public void SetIsCommon(bool is_common)
    {
    }

    [Token(Token = "0x6009873")]
    [Address(RVA = "0x5B0820", Offset = "0x5AF620", VA = "0x105B0820")]
    public void SetIsCommonLine(bool is_common)
    {
    }

    [Token(Token = "0x6009874")]
    [Address(RVA = "0x2ACF80", Offset = "0x2ABD80", VA = "0x102ACF80")]
    public EquipRecipeItem()
    {
    }
  }
}
