// Decompiled with JetBrains decompiler
// Type: SRPG.TipsQuestItem
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x2002B2A")]
  [AddComponentMenu("UI/TipsQuestItem")]
  public class TipsQuestItem : MonoBehaviour
  {
    [Token(Token = "0x400D2B1")]
    [FieldOffset(Offset = "0xC")]
    [SerializeField]
    private GameObject BadgeObj;
    [Token(Token = "0x400D2B2")]
    [FieldOffset(Offset = "0x10")]
    [SerializeField]
    private GameObject CompleteObj;
    [Token(Token = "0x400D2B3")]
    [FieldOffset(Offset = "0x14")]
    [SerializeField]
    private Text TitleTxt;
    [Token(Token = "0x400D2B4")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    private Text NameTxt;
    [Token(Token = "0x400D2B5")]
    [FieldOffset(Offset = "0x1C")]
    public string Title;
    [Token(Token = "0x400D2B6")]
    [FieldOffset(Offset = "0x20")]
    public string Name;
    [Token(Token = "0x400D2B7")]
    [FieldOffset(Offset = "0x24")]
    public bool IsCompleted;

    [Token(Token = "0x600C587")]
    [Address(RVA = "0x8E0F40", Offset = "0x8DFD40", VA = "0x108E0F40")]
    public void UpdateContent()
    {
    }

    [Token(Token = "0x600C588")]
    [Address(RVA = "0x2ACF80", Offset = "0x2ABD80", VA = "0x102ACF80")]
    public TipsQuestItem()
    {
    }
  }
}
