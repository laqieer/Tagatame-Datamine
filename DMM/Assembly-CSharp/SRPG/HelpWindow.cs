// Decompiled with JetBrains decompiler
// Type: SRPG.HelpWindow
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x2002619")]
  [AddComponentMenu("UI/HelpWindow")]
  public class HelpWindow : MonoBehaviour
  {
    [Token(Token = "0x400B16C")]
    [FieldOffset(Offset = "0x0")]
    public static readonly string VAR_NAME_MENU_ID;
    [Token(Token = "0x400B16D")]
    [FieldOffset(Offset = "0xC")]
    public bool ReferenceFlowVariable;
    [Token(Token = "0x400B16E")]
    [FieldOffset(Offset = "0x10")]
    public Button BackButton;
    [Token(Token = "0x400B16F")]
    [FieldOffset(Offset = "0x14")]
    public Button MiddleBackButton;
    [Token(Token = "0x400B170")]
    [FieldOffset(Offset = "0x18")]
    private bool bMiddleHelp;
    [Token(Token = "0x400B171")]
    [FieldOffset(Offset = "0x1C")]
    private int SelMiddleIdx;
    [Token(Token = "0x400B172")]
    [FieldOffset(Offset = "0x20")]
    private GameObject[] mHelpMenuButtons;
    [Token(Token = "0x400B173")]
    [FieldOffset(Offset = "0x24")]
    public GameObject m_HelpMain;

    [Token(Token = "0x170017E3")]
    public bool MiddleHelp
    {
      [Token(Token = "0x600A9E1"), Address(RVA = "0x3057E0", Offset = "0x3045E0", VA = "0x103057E0")] get
      {
        return new bool();
      }
    }

    [Token(Token = "0x170017E4")]
    public int SelectMiddleID
    {
      [Token(Token = "0x600A9E2"), Address(RVA = "0x2700B0", Offset = "0x26EEB0", VA = "0x102700B0")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x600A9E3")]
    [Address(RVA = "0x6D28B0", Offset = "0x6D16B0", VA = "0x106D28B0")]
    private void Start()
    {
    }

    [Token(Token = "0x600A9E4")]
    [Address(RVA = "0x6D26B0", Offset = "0x6D14B0", VA = "0x106D26B0")]
    private void OnDestroy()
    {
    }

    [Token(Token = "0x600A9E5")]
    [Address(RVA = "0x6D2600", Offset = "0x6D1400", VA = "0x106D2600")]
    private void OnCloseMain()
    {
    }

    [Token(Token = "0x600A9E6")]
    [Address(RVA = "0x6D2570", Offset = "0x6D1370", VA = "0x106D2570")]
    public void OnBackList()
    {
    }

    [Token(Token = "0x600A9E7")]
    [Address(RVA = "0x6D2D30", Offset = "0x6D1B30", VA = "0x106D2D30")]
    public void UpdateHelpList(bool flag, int Idx)
    {
    }

    [Token(Token = "0x600A9E8")]
    [Address(RVA = "0x6D1D70", Offset = "0x6D0B70", VA = "0x106D1D70")]
    public void CreateMainWindow(int MenuID)
    {
    }

    [Token(Token = "0x600A9E9")]
    [Address(RVA = "0x6D2700", Offset = "0x6D1500", VA = "0x106D2700")]
    private bool SetImageData(Transform image, string childname, string texname) => new bool();

    [Token(Token = "0x600A9EA")]
    [Address(RVA = "0x6D2C90", Offset = "0x6D1A90", VA = "0x106D2C90")]
    private float TextHeight(string text, LText ltext) => new float();

    [Token(Token = "0x600A9EB")]
    [Address(RVA = "0x2ACF80", Offset = "0x2ABD80", VA = "0x102ACF80")]
    public HelpWindow()
    {
    }

    [Token(Token = "0x600A9EC")]
    [Address(RVA = "0x6D2FD0", Offset = "0x6D1DD0", VA = "0x106D2FD0")]
    static HelpWindow()
    {
    }

    [Token(Token = "0x200261A")]
    private enum HELP_ID
    {
      [Token(Token = "0x400B175")] ACTION = 61, // 0x0000003D
      [Token(Token = "0x400B176")] REACTION = 62, // 0x0000003E
      [Token(Token = "0x400B177")] SUPPORT = 63, // 0x0000003F
      [Token(Token = "0x400B178")] SHOP = 96, // 0x00000060
    }
  }
}
