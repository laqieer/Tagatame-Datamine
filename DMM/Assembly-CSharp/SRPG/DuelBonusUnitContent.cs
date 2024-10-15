// Decompiled with JetBrains decompiler
// Type: SRPG.DuelBonusUnitContent
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x2002307")]
  [AddComponentMenu("UI/Duel/DuelBonusUnitContent")]
  public class DuelBonusUnitContent : MonoBehaviour
  {
    [Token(Token = "0x4009C53")]
    [FieldOffset(Offset = "0xC")]
    [SerializeField]
    private GameObject mUnitIconTemplate;
    [Token(Token = "0x4009C54")]
    [FieldOffset(Offset = "0x10")]
    [SerializeField]
    private Text mRateText;

    [Token(Token = "0x60096C6")]
    [Address(RVA = "0x597060", Offset = "0x595E60", VA = "0x10597060")]
    public void Setup(DuelBonusUnit bonus_param)
    {
    }

    [Token(Token = "0x60096C7")]
    [Address(RVA = "0x2ACF80", Offset = "0x2ABD80", VA = "0x102ACF80")]
    public DuelBonusUnitContent()
    {
    }
  }
}
