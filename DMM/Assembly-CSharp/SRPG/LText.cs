// Decompiled with JetBrains decompiler
// Type: SRPG.LText
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x20026FD")]
  public class LText : Text
  {
    [Token(Token = "0x400B7B5")]
    [FieldOffset(Offset = "0x98")]
    [SerializeField]
    [HideInInspector]
    private bool mReplaceNoBreakSpace;
    [Token(Token = "0x400B7B6")]
    [FieldOffset(Offset = "0x9C")]
    private string mCurrentText;

    [Token(Token = "0x17001830")]
    public bool ReplaceNoBreakSpace
    {
      [Token(Token = "0x600AEB5"), Address(RVA = "0x3A64B0", Offset = "0x3A52B0", VA = "0x103A64B0")] get
      {
        return new bool();
      }
      [Token(Token = "0x600AEB6"), Address(RVA = "0x71F370", Offset = "0x71E170", VA = "0x1071F370")] set
      {
      }
    }

    [Token(Token = "0x600AEB7")]
    [Address(RVA = "0x71F1D0", Offset = "0x71DFD0", VA = "0x1071F1D0")]
    public void ForceReplaceLocalizedText()
    {
    }

    [Token(Token = "0x600AEB8")]
    [Address(RVA = "0x71F1E0", Offset = "0x71DFE0", VA = "0x1071F1E0")]
    private void LateUpdate()
    {
    }

    [Token(Token = "0x600AEB9")]
    [Address(RVA = "0x71F280", Offset = "0x71E080", VA = "0x1071F280")]
    private void ReplaceLocalizedText()
    {
    }

    [Token(Token = "0x600AEBA")]
    [Address(RVA = "0x71F360", Offset = "0x71E160", VA = "0x1071F360")]
    public LText()
    {
    }
  }
}
