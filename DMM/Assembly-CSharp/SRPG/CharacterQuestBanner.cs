// Decompiled with JetBrains decompiler
// Type: SRPG.CharacterQuestBanner
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x200213D")]
  [AddComponentMenu("UI/CharacterQuestBanner")]
  public class CharacterQuestBanner : MonoBehaviour, IGameParameter
  {
    [Token(Token = "0x40090B4")]
    [FieldOffset(Offset = "0xC")]
    [SerializeField]
    private GameObject UnitIcon1;
    [Token(Token = "0x40090B5")]
    [FieldOffset(Offset = "0x10")]
    [SerializeField]
    private GameObject UnitIcon2;
    [Token(Token = "0x40090B6")]
    [FieldOffset(Offset = "0x14")]
    [SerializeField]
    private Image LockIcon;
    [Token(Token = "0x40090B7")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    private Image CompleteIcon;
    [Token(Token = "0x40090B8")]
    [FieldOffset(Offset = "0x1C")]
    [SerializeField]
    private Image NewIcon;
    [Token(Token = "0x40090B9")]
    [FieldOffset(Offset = "0x20")]
    [SerializeField]
    private GameObject Unlocks;
    [Token(Token = "0x40090BA")]
    [FieldOffset(Offset = "0x24")]
    private UnityAction UnitIconClickCallback1;
    [Token(Token = "0x40090BB")]
    [FieldOffset(Offset = "0x28")]
    private UnityAction UnitIconClickCallback2;

    [Token(Token = "0x6008B7B")]
    [Address(RVA = "0x4F6B70", Offset = "0x4F5970", VA = "0x104F6B70")]
    private void Start()
    {
    }

    [Token(Token = "0x6008B7C")]
    [Address(RVA = "0x4F6D30", Offset = "0x4F5B30", VA = "0x104F6D30", Slot = "4")]
    public void UpdateValue()
    {
    }

    [Token(Token = "0x6008B7D")]
    [Address(RVA = "0x4F6970", Offset = "0x4F5770", VA = "0x104F6970")]
    private void DataBind(UnitData unitData, UnitParam unitParam, GameObject target)
    {
    }

    [Token(Token = "0x6008B7E")]
    [Address(RVA = "0x4F6830", Offset = "0x4F5630", VA = "0x104F6830")]
    private void ChangeStatusIcon(CharacterQuestData.EStatus status)
    {
    }

    [Token(Token = "0x6008B7F")]
    [Address(RVA = "0x4F6A00", Offset = "0x4F5800", VA = "0x104F6A00")]
    private void OnUnitIcon1_Click()
    {
    }

    [Token(Token = "0x6008B80")]
    [Address(RVA = "0x4F6A20", Offset = "0x4F5820", VA = "0x104F6A20")]
    private void OnUnitIcon2_Click()
    {
    }

    [Token(Token = "0x6008B81")]
    [Address(RVA = "0x4F6A40", Offset = "0x4F5840", VA = "0x104F6A40")]
    private void OnUnitIconClickInternal(GameObject go)
    {
    }

    [Token(Token = "0x6008B82")]
    [Address(RVA = "0x2ACF80", Offset = "0x2ABD80", VA = "0x102ACF80")]
    public CharacterQuestBanner()
    {
    }
  }
}
