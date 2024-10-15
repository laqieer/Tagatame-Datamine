// Decompiled with JetBrains decompiler
// Type: SRPG.TruthEquipmentIcon
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x2002B8E")]
  [AddComponentMenu("UI/TruthEquipment/TruthEquipmentIcon")]
  public class TruthEquipmentIcon : MonoBehaviour
  {
    [Token(Token = "0x400D5B8")]
    [FieldOffset(Offset = "0xC")]
    [SerializeField]
    private RawImage m_ImgIcon;
    [Token(Token = "0x400D5B9")]
    [FieldOffset(Offset = "0x10")]
    [SerializeField]
    private Text m_TxtName;
    [Token(Token = "0x400D5BA")]
    [FieldOffset(Offset = "0x14")]
    [SerializeField]
    private Text m_TxtLv;
    [Token(Token = "0x400D5BB")]
    [FieldOffset(Offset = "0x18")]
    private TruthEquipmentData m_TruthEquipmentData;
    [Token(Token = "0x400D5BC")]
    [FieldOffset(Offset = "0x1C")]
    private TruthEquipmentParam m_TruthEquipmentParam;

    [Token(Token = "0x600C7F3")]
    [Address(RVA = "0x90D640", Offset = "0x90C440", VA = "0x1090D640")]
    public void Setup(TruthEquipmentData data)
    {
    }

    [Token(Token = "0x600C7F4")]
    [Address(RVA = "0x90D460", Offset = "0x90C260", VA = "0x1090D460")]
    private void LoadIcon()
    {
    }

    [Token(Token = "0x600C7F5")]
    [Address(RVA = "0x90D5C0", Offset = "0x90C3C0", VA = "0x1090D5C0")]
    private void RefreshNameText()
    {
    }

    [Token(Token = "0x600C7F6")]
    [Address(RVA = "0x90D520", Offset = "0x90C320", VA = "0x1090D520")]
    private void RefreshLvText()
    {
    }

    [Token(Token = "0x600C7F7")]
    [Address(RVA = "0x2ACF80", Offset = "0x2ABD80", VA = "0x102ACF80")]
    public TruthEquipmentIcon()
    {
    }
  }
}
