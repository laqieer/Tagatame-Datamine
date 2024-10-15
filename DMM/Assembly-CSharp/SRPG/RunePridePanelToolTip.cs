// Decompiled with JetBrains decompiler
// Type: SRPG.RunePridePanelToolTip
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
  [Token(Token = "0x2002A2E")]
  public class RunePridePanelToolTip : MonoBehaviour
  {
    [Token(Token = "0x400CCE5")]
    [FieldOffset(Offset = "0xC")]
    [SerializeField]
    public RectTransform Body;
    [Token(Token = "0x400CCE6")]
    [FieldOffset(Offset = "0x10")]
    [SerializeField]
    public Text TextObj;

    [Token(Token = "0x600C045")]
    [Address(RVA = "0x88A0E0", Offset = "0x888EE0", VA = "0x1088A0E0")]
    public void Setup(RunePridePanelSquareModel model)
    {
    }

    [Token(Token = "0x600C046")]
    [Address(RVA = "0x2ACF80", Offset = "0x2ABD80", VA = "0x102ACF80")]
    public RunePridePanelToolTip()
    {
    }
  }
}
