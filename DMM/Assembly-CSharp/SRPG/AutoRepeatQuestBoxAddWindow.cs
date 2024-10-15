// Decompiled with JetBrains decompiler
// Type: SRPG.AutoRepeatQuestBoxAddWindow
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x2002062")]
  [AddComponentMenu("UI/AutoRepeatQuest/AutoRepeatQuestBoxAddWindow")]
  public class AutoRepeatQuestBoxAddWindow : MonoBehaviour
  {
    [Token(Token = "0x4008B30")]
    [FieldOffset(Offset = "0xC")]
    [SerializeField]
    private Text mMessageText;
    [Token(Token = "0x4008B31")]
    [FieldOffset(Offset = "0x10")]
    [SerializeField]
    private Button mDecideButton;

    [Token(Token = "0x600868B")]
    [Address(RVA = "0x47E5E0", Offset = "0x47D3E0", VA = "0x1047E5E0")]
    private void Start()
    {
    }

    [Token(Token = "0x600868C")]
    [Address(RVA = "0x47E150", Offset = "0x47CF50", VA = "0x1047E150")]
    private void InitText()
    {
    }

    [Token(Token = "0x600868D")]
    [Address(RVA = "0x2ACF80", Offset = "0x2ABD80", VA = "0x102ACF80")]
    public AutoRepeatQuestBoxAddWindow()
    {
    }
  }
}
