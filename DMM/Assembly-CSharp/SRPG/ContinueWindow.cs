// Decompiled with JetBrains decompiler
// Type: SRPG.ContinueWindow
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
  [Token(Token = "0x200225E")]
  [AddComponentMenu("UI/ContinueWindow")]
  public class ContinueWindow : MonoBehaviour
  {
    [Token(Token = "0x40098BF")]
    [FieldOffset(Offset = "0xC")]
    public Text Message;
    [Token(Token = "0x40098C0")]
    [FieldOffset(Offset = "0x10")]
    public Text CoinNum;
    [Token(Token = "0x40098C1")]
    [FieldOffset(Offset = "0x14")]
    public Button ButtonOk;
    [Token(Token = "0x40098C2")]
    [FieldOffset(Offset = "0x18")]
    public Button ButtonCancel;
    [Token(Token = "0x40098C3")]
    [FieldOffset(Offset = "0x1C")]
    public GameObject Prefab_NewItemBadge;
    [Token(Token = "0x40098C4")]
    [FieldOffset(Offset = "0x20")]
    public GameObject TreasureList;
    [Token(Token = "0x40098C5")]
    [FieldOffset(Offset = "0x24")]
    public GameObject TreasureListNode;
    [Token(Token = "0x40098C6")]
    [FieldOffset(Offset = "0x28")]
    private Animator m_Animator;
    [Token(Token = "0x40098C7")]
    [FieldOffset(Offset = "0x2C")]
    private List<GameObject> m_TreasureListNodes;
    [Token(Token = "0x40098C8")]
    [FieldOffset(Offset = "0x30")]
    private ContinueWindow.Result m_Result;
    [Token(Token = "0x40098C9")]
    [FieldOffset(Offset = "0x34")]
    private bool m_Destroy;
    [Token(Token = "0x40098CA")]
    [FieldOffset(Offset = "0x38")]
    private ContinueWindow.ResultEvent OnClickOk;
    [Token(Token = "0x40098CB")]
    [FieldOffset(Offset = "0x3C")]
    private ContinueWindow.ResultEvent OnClickCancel;
    [Token(Token = "0x40098CC")]
    [FieldOffset(Offset = "0x0")]
    private static Canvas m_ModalCanvas;

    [Token(Token = "0x60092F7")]
    [Address(RVA = "0x5637B0", Offset = "0x5625B0", VA = "0x105637B0")]
    public static bool Create(
      GameObject res,
      ContinueWindow.ResultEvent ok,
      ContinueWindow.ResultEvent cancel)
    {
      return new bool();
    }

    [Token(Token = "0x60092F8")]
    [Address(RVA = "0x563950", Offset = "0x562750", VA = "0x10563950")]
    public static void Destroy()
    {
    }

    [Token(Token = "0x60092F9")]
    [Address(RVA = "0x563A20", Offset = "0x562820", VA = "0x10563A20")]
    public static void ForceClose()
    {
    }

    [Token(Token = "0x60092FA")]
    [Address(RVA = "0x563EB0", Offset = "0x562CB0", VA = "0x10563EB0")]
    private void Start()
    {
    }

    [Token(Token = "0x60092FB")]
    [Address(RVA = "0x5644D0", Offset = "0x5632D0", VA = "0x105644D0")]
    public void Update()
    {
    }

    [Token(Token = "0x60092FC")]
    [Address(RVA = "0x563E90", Offset = "0x562C90", VA = "0x10563E90")]
    public void Open()
    {
    }

    [Token(Token = "0x60092FD")]
    [Address(RVA = "0x563720", Offset = "0x562520", VA = "0x10563720")]
    public void Close(bool destroy)
    {
    }

    [Token(Token = "0x60092FE")]
    [Address(RVA = "0x563C80", Offset = "0x562A80", VA = "0x10563C80")]
    public bool IsOpend() => new bool();

    [Token(Token = "0x60092FF")]
    [Address(RVA = "0x563AF0", Offset = "0x5628F0", VA = "0x10563AF0")]
    public bool IsClosed() => new bool();

    [Token(Token = "0x6009300")]
    [Address(RVA = "0x563E10", Offset = "0x562C10", VA = "0x10563E10")]
    private void OnClickButton(GameObject obj)
    {
    }

    [Token(Token = "0x6009301")]
    [Address(RVA = "0x5646A0", Offset = "0x5634A0", VA = "0x105646A0")]
    public ContinueWindow()
    {
    }

    [Token(Token = "0x200225F")]
    public delegate void ResultEvent(GameObject dialog);

    [Token(Token = "0x2002260")]
    private enum Result
    {
      [Token(Token = "0x40098CE")] NONE,
      [Token(Token = "0x40098CF")] OK,
      [Token(Token = "0x40098D0")] CANCEL,
    }
  }
}
