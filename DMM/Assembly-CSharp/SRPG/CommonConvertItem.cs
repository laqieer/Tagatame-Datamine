// Decompiled with JetBrains decompiler
// Type: SRPG.CommonConvertItem
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x20021C0")]
  [AddComponentMenu("UI/CommonConvertItem")]
  public class CommonConvertItem : MonoBehaviour
  {
    [Token(Token = "0x40093F5")]
    [FieldOffset(Offset = "0xC")]
    public GameObject Obj;
    [Token(Token = "0x40093F6")]
    [FieldOffset(Offset = "0x10")]
    public GameObject CommonObj;
    [Token(Token = "0x40093F7")]
    [FieldOffset(Offset = "0x14")]
    public LText Amount;
    [Token(Token = "0x40093F8")]
    [FieldOffset(Offset = "0x18")]
    public LText ItemName;
    [Token(Token = "0x40093F9")]
    [FieldOffset(Offset = "0x1C")]
    public Text ItemUseNum;
    [Token(Token = "0x40093FA")]
    [FieldOffset(Offset = "0x20")]
    public Text CommonItemUseNum;

    [Token(Token = "0x6008E3F")]
    [Address(RVA = "0x5174B0", Offset = "0x5162B0", VA = "0x105174B0")]
    public void Bind(ItemData data, ItemData cmmon_data, int need_num)
    {
    }

    [Token(Token = "0x6008E40")]
    [Address(RVA = "0x2781C0", Offset = "0x276FC0", VA = "0x102781C0")]
    public void Refresh(ItemData data, ItemData cmmon_data)
    {
    }

    [Token(Token = "0x6008E41")]
    [Address(RVA = "0x2ACF80", Offset = "0x2ABD80", VA = "0x102ACF80")]
    public CommonConvertItem()
    {
    }
  }
}
