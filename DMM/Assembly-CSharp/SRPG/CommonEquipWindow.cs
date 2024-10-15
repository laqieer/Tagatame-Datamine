// Decompiled with JetBrains decompiler
// Type: SRPG.CommonEquipWindow
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x20021C1")]
  [AddComponentMenu("UI/CommonEquipWindow")]
  public class CommonEquipWindow : MonoBehaviour
  {
    [Token(Token = "0x40093FB")]
    [FieldOffset(Offset = "0xC")]
    public Text CommonName;
    [Token(Token = "0x40093FC")]
    [FieldOffset(Offset = "0x10")]
    public Text CommonAmount;
    [Token(Token = "0x40093FD")]
    [FieldOffset(Offset = "0x14")]
    public Text CommonDescription;
    [Token(Token = "0x40093FE")]
    [FieldOffset(Offset = "0x18")]
    public Text CommonDescriptionPieceNotEnough;
    [Token(Token = "0x40093FF")]
    [FieldOffset(Offset = "0x1C")]
    public Text CommonCost;
    [Token(Token = "0x4009400")]
    [FieldOffset(Offset = "0x20")]
    public GameObject NotEnough;
    [Token(Token = "0x4009401")]
    [FieldOffset(Offset = "0x24")]
    public Button ButtonCommonEquip;

    [Token(Token = "0x6008E42")]
    [Address(RVA = "0x517AC0", Offset = "0x5168C0", VA = "0x10517AC0")]
    private void Start()
    {
    }

    [Token(Token = "0x6008E43")]
    [Address(RVA = "0x517750", Offset = "0x516550", VA = "0x10517750")]
    private void Refresh()
    {
    }

    [Token(Token = "0x6008E44")]
    [Address(RVA = "0x2ACF80", Offset = "0x2ABD80", VA = "0x102ACF80")]
    public CommonEquipWindow()
    {
    }
  }
}
