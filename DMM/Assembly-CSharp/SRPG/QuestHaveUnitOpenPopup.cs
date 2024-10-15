// Decompiled with JetBrains decompiler
// Type: SRPG.QuestHaveUnitOpenPopup
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using UnityEngine;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x2002898")]
  [AddComponentMenu("UI/QuestHaveUnitOpenPopup")]
  public class QuestHaveUnitOpenPopup : MonoBehaviour
  {
    [Token(Token = "0x400C247")]
    [FieldOffset(Offset = "0xC")]
    [SerializeField]
    private string MessageLText;
    [Token(Token = "0x400C248")]
    [FieldOffset(Offset = "0x10")]
    private GameObject mMsg;

    [Token(Token = "0x600B77F")]
    [Address(RVA = "0x7E3AA0", Offset = "0x7E28A0", VA = "0x107E3AA0")]
    public void OnClick(GameObject go)
    {
    }

    [Token(Token = "0x600B780")]
    [Address(RVA = "0x7E3C90", Offset = "0x7E2A90", VA = "0x107E3C90")]
    public void OnConfirm(GameObject go)
    {
    }

    [Token(Token = "0x600B781")]
    [Address(RVA = "0x2ACF80", Offset = "0x2ABD80", VA = "0x102ACF80")]
    public QuestHaveUnitOpenPopup()
    {
    }
  }
}
