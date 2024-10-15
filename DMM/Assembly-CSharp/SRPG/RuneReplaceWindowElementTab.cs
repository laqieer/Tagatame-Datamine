// Decompiled with JetBrains decompiler
// Type: SRPG.RuneReplaceWindowElementTab
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using SRPG.Models;
using UnityEngine;
using UnityEngine.UI;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x20029CB")]
  public class RuneReplaceWindowElementTab : MonoBehaviour
  {
    [Token(Token = "0x400CAE7")]
    [FieldOffset(Offset = "0xC")]
    [SerializeField]
    private RuneReplaceWindowElementTabModel.TabCategoryType mTabCategoryType;
    [Token(Token = "0x400CAE8")]
    [FieldOffset(Offset = "0x10")]
    [SerializeField]
    private EElement mElementType;
    [Token(Token = "0x400CAE9")]
    [FieldOffset(Offset = "0x14")]
    [SerializeField]
    private RuneReplaceWindow mWindow;
    [Token(Token = "0x400CAEA")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    private Toggle mToggle;
    [Token(Token = "0x400CAEB")]
    [FieldOffset(Offset = "0x1C")]
    [SerializeField]
    private SystemSound mTabSoundEffect;
    [Token(Token = "0x400CAEC")]
    [FieldOffset(Offset = "0x20")]
    private RuneReplaceWindowElementTabModel mModel;

    [Token(Token = "0x600BE57")]
    [Address(RVA = "0x85B1A0", Offset = "0x859FA0", VA = "0x1085B1A0")]
    public void Initialize()
    {
    }

    [Token(Token = "0x600BE58")]
    [Address(RVA = "0x85B2D0", Offset = "0x85A0D0", VA = "0x1085B2D0")]
    public void Initialize(
      RuneReplaceWindowElementTabModel.TabCategoryType type,
      EElement element)
    {
    }

    [Token(Token = "0x600BE59")]
    [Address(RVA = "0x288700", Offset = "0x287500", VA = "0x10288700")]
    public void Initialize(RuneReplaceWindowElementTabModel model)
    {
    }

    [Token(Token = "0x600BE5A")]
    [Address(RVA = "0x85B4F0", Offset = "0x85A2F0", VA = "0x1085B4F0")]
    public void SetToggleStatus(bool isOn)
    {
    }

    [Token(Token = "0x600BE5B")]
    [Address(RVA = "0x85B4D0", Offset = "0x85A2D0", VA = "0x1085B4D0")]
    public void OnToggleChangeValue(bool isOn)
    {
    }

    [Token(Token = "0x600BE5C")]
    [Address(RVA = "0x85B3F0", Offset = "0x85A1F0", VA = "0x1085B3F0")]
    public void OnClickTab(bool isSound = true)
    {
    }

    [Token(Token = "0x600BE5D")]
    [Address(RVA = "0x2ACF80", Offset = "0x2ABD80", VA = "0x102ACF80")]
    public RuneReplaceWindowElementTab()
    {
    }
  }
}
