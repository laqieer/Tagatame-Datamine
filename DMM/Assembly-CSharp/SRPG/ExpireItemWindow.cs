// Decompiled with JetBrains decompiler
// Type: SRPG.ExpireItemWindow
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x20023A9")]
  [AddComponentMenu("UI/ExpireItemWindow")]
  public class ExpireItemWindow : MonoBehaviour
  {
    [Token(Token = "0x400A10C")]
    [FieldOffset(Offset = "0xC")]
    [SerializeField]
    private GameObject mTemplate;
    [Token(Token = "0x400A10D")]
    [FieldOffset(Offset = "0x10")]
    [SerializeField]
    private GameObject mTitle_Warning;
    [Token(Token = "0x400A10E")]
    [FieldOffset(Offset = "0x14")]
    [SerializeField]
    private GameObject mTitle_Expired;
    [Token(Token = "0x400A10F")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    private Text mWarningText_1;
    [Token(Token = "0x400A110")]
    [FieldOffset(Offset = "0x1C")]
    [SerializeField]
    private Text mWarningText_2;

    [Token(Token = "0x6009A56")]
    [Address(RVA = "0x5E88C0", Offset = "0x5E76C0", VA = "0x105E88C0")]
    public void Setup_ExpireWarning(List<ItemData> item_list, int rest_day)
    {
    }

    [Token(Token = "0x6009A57")]
    [Address(RVA = "0x5E8C10", Offset = "0x5E7A10", VA = "0x105E8C10")]
    public void Setup_ExpiredNotify(ExpireItemParamList expire_item)
    {
    }

    [Token(Token = "0x6009A58")]
    [Address(RVA = "0x2ACF80", Offset = "0x2ABD80", VA = "0x102ACF80")]
    public ExpireItemWindow()
    {
    }
  }
}
