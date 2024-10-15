// Decompiled with JetBrains decompiler
// Type: SRPG.QuestCampaignIcon
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x200288C")]
  [AddComponentMenu("UI/QuestCampaignIcon")]
  public class QuestCampaignIcon : MonoBehaviour
  {
    [Token(Token = "0x400C1D2")]
    [FieldOffset(Offset = "0xC")]
    public Text Text;
    [Token(Token = "0x400C1D3")]
    [FieldOffset(Offset = "0x10")]
    public Image UnitIcon;

    [Token(Token = "0x600B730")]
    [Address(RVA = "0x7DA6F0", Offset = "0x7D94F0", VA = "0x107DA6F0")]
    private void Start()
    {
    }

    [Token(Token = "0x600B731")]
    [Address(RVA = "0x7DA580", Offset = "0x7D9380", VA = "0x107DA580")]
    private bool SetUnitIcon(QuestCampaignData data) => new bool();

    [Token(Token = "0x600B732")]
    [Address(RVA = "0x7DA830", Offset = "0x7D9630", VA = "0x107DA830")]
    private void ValueToFraction(int value, out int num, out int denom)
    {
    }

    [Token(Token = "0x600B733")]
    [Address(RVA = "0x7DA8E0", Offset = "0x7D96E0", VA = "0x107DA8E0")]
    private string ValueToString(int value) => (string) null;

    [Token(Token = "0x600B734")]
    [Address(RVA = "0x2ACF80", Offset = "0x2ABD80", VA = "0x102ACF80")]
    public QuestCampaignIcon()
    {
    }
  }
}
