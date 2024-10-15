// Decompiled with JetBrains decompiler
// Type: SRPG.EventPopupListItem
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x2002372")]
  [AddComponentMenu("UI/EventPopupListItem")]
  public class EventPopupListItem : MonoBehaviour
  {
    [Token(Token = "0x4009F56")]
    [FieldOffset(Offset = "0xC")]
    [SerializeField]
    private Image BannerImage;
    [Token(Token = "0x4009F57")]
    [FieldOffset(Offset = "0x10")]
    [SerializeField]
    private Text EndAtText;
    [Token(Token = "0x4009F58")]
    [FieldOffset(Offset = "0x14")]
    [SerializeField]
    private Text MessageText;
    [Token(Token = "0x4009F59")]
    [FieldOffset(Offset = "0x18")]
    private BannerParam m_Param;

    [Token(Token = "0x6009917")]
    [Address(RVA = "0x5CE230", Offset = "0x5CD030", VA = "0x105CE230")]
    public void SetupBannerParam(BannerParam _param)
    {
    }

    [Token(Token = "0x6009918")]
    [Address(RVA = "0x5CDF80", Offset = "0x5CCD80", VA = "0x105CDF80")]
    private void Refresh()
    {
    }

    [Token(Token = "0x6009919")]
    [Address(RVA = "0x2ACF80", Offset = "0x2ABD80", VA = "0x102ACF80")]
    public EventPopupListItem()
    {
    }
  }
}
