// Decompiled with JetBrains decompiler
// Type: SRPG.SRPG_InputField
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x2002AF7")]
  [AddComponentMenu("UI/InputField (SRPG)")]
  public class SRPG_InputField : InputField
  {
    [Token(Token = "0x400D1A1")]
    [FieldOffset(Offset = "0x170")]
    private bool m_IsPointerOutofRange;
    [Token(Token = "0x400D1A2")]
    [FieldOffset(Offset = "0x174")]
    private UnityEngine.Event m_EventWork;
    [Token(Token = "0x400D1A3")]
    [FieldOffset(Offset = "0x0")]
    private static bool NowInput;
    [Token(Token = "0x400D1A4")]
    [FieldOffset(Offset = "0x4")]
    private static readonly char[] Separators;
    [Token(Token = "0x400D1A5")]
    [FieldOffset(Offset = "0x178")]
    private CanvasRenderer m_Renderer;
    [Token(Token = "0x400D1A6")]
    [FieldOffset(Offset = "0x17C")]
    private RectTransform m_RectTrans;

    [Token(Token = "0x17001A27")]
    public static bool IsFocus
    {
      [Token(Token = "0x600C46E"), Address(RVA = "0x8CA500", Offset = "0x8C9300", VA = "0x108CA500")] get
      {
        return new bool();
      }
    }

    [Token(Token = "0x600C46F")]
    [Address(RVA = "0x8CA080", Offset = "0x8C8E80", VA = "0x108CA080")]
    public static void ResetInput()
    {
    }

    [Token(Token = "0x600C470")]
    [Address(RVA = "0x8C9E10", Offset = "0x8C8C10", VA = "0x108C9E10", Slot = "34")]
    public override void OnPointerEnter(PointerEventData eventData)
    {
    }

    [Token(Token = "0x600C471")]
    [Address(RVA = "0x8C9E30", Offset = "0x8C8C30", VA = "0x108C9E30", Slot = "35")]
    public override void OnPointerExit(PointerEventData eventData)
    {
    }

    [Token(Token = "0x600C472")]
    [Address(RVA = "0x8C9E60", Offset = "0x8C8C60", VA = "0x108C9E60", Slot = "65")]
    public override void OnUpdateSelected(BaseEventData eventData)
    {
    }

    [Token(Token = "0x600C473")]
    [Address(RVA = "0x8C8900", Offset = "0x8C7700", VA = "0x108C8900")]
    private bool GetMouseButtonDown() => new bool();

    [Token(Token = "0x600C474")]
    [Address(RVA = "0x8C9E50", Offset = "0x8C8C50", VA = "0x108C9E50", Slot = "36")]
    public override void OnSelect(BaseEventData eventData)
    {
    }

    [Token(Token = "0x600C475")]
    [Address(RVA = "0x8C9A10", Offset = "0x8C8810", VA = "0x108C9A10", Slot = "37")]
    public override void OnDeselect(BaseEventData eventData)
    {
    }

    [Token(Token = "0x600C476")]
    [Address(RVA = "0x8C7870", Offset = "0x8C6670", VA = "0x108C7870", Slot = "82")]
    public virtual void ForceSetText(string text)
    {
    }

    [Token(Token = "0x600C477")]
    [Address(RVA = "0x8C9A20", Offset = "0x8C8820", VA = "0x108C9A20", Slot = "8")]
    protected override void OnDestroy()
    {
    }

    [Token(Token = "0x17001A28")]
    private static string clipboard
    {
      [Token(Token = "0x600C478"), Address(RVA = "0x8CA540", Offset = "0x8C9340", VA = "0x108CA540")] get
      {
        return (string) null;
      }
      [Token(Token = "0x600C479"), Address(RVA = "0x8CA550", Offset = "0x8C9350", VA = "0x108CA550")] set
      {
      }
    }

    [Token(Token = "0x600C47A")]
    [Address(RVA = "0x8C7540", Offset = "0x8C6340", VA = "0x108C7540")]
    private void DeleteForWin()
    {
    }

    [Token(Token = "0x600C47B")]
    [Address(RVA = "0x8CA0C0", Offset = "0x8C8EC0", VA = "0x108CA0C0")]
    private void SendOnValueChangedAndUpdateLabelForWin()
    {
    }

    [Token(Token = "0x600C47C")]
    [Address(RVA = "0x8C8930", Offset = "0x8C7730", VA = "0x108C8930")]
    private string GetSelectedStringForWin() => (string) null;

    [Token(Token = "0x600C47D")]
    [Address(RVA = "0x8C77E0", Offset = "0x8C65E0", VA = "0x108C77E0")]
    private int FindtPrevWordBegin() => new int();

    [Token(Token = "0x600C47E")]
    [Address(RVA = "0x8C7730", Offset = "0x8C6530", VA = "0x108C7730")]
    private int FindtNextWordBeginForWin() => new int();

    [Token(Token = "0x600C47F")]
    [Address(RVA = "0x8C96F0", Offset = "0x8C84F0", VA = "0x108C96F0")]
    private void MoveLeft(bool shift, bool ctrl)
    {
    }

    [Token(Token = "0x600C480")]
    [Address(RVA = "0x8C9820", Offset = "0x8C8620", VA = "0x108C9820")]
    private void MoveRight(bool shift, bool ctrl)
    {
    }

    [Token(Token = "0x600C481")]
    [Address(RVA = "0x8C8850", Offset = "0x8C7650", VA = "0x108C8850")]
    private static int GetLineEndPositionForWin(TextGenerator gen, int line) => new int();

    [Token(Token = "0x600C482")]
    [Address(RVA = "0x8C7690", Offset = "0x8C6490", VA = "0x108C7690")]
    private int DetermineCharacterLineForWin(int charPos, TextGenerator generator) => new int();

    [Token(Token = "0x600C483")]
    [Address(RVA = "0x8C9480", Offset = "0x8C8280", VA = "0x108C9480")]
    private int LineUpCharacterPosition(int originalPos, bool goToFirstChar) => new int();

    [Token(Token = "0x600C484")]
    [Address(RVA = "0x8C92A0", Offset = "0x8C80A0", VA = "0x108C92A0")]
    private int LineDownCharacterPosition(int originalPos, bool goToLastChar) => new int();

    [Token(Token = "0x600C485")]
    [Address(RVA = "0x8C9630", Offset = "0x8C8430", VA = "0x108C9630")]
    private void MoveDown(bool shift, bool goToLastChar)
    {
    }

    [Token(Token = "0x600C486")]
    [Address(RVA = "0x8C9960", Offset = "0x8C8760", VA = "0x108C9960")]
    private void MoveUp(bool shift, bool goToFirstChar)
    {
    }

    [Token(Token = "0x600C487")]
    [Address(RVA = "0x8C7940", Offset = "0x8C6740", VA = "0x108C7940")]
    private void ForwardSpaceForWin()
    {
    }

    [Token(Token = "0x600C488")]
    [Address(RVA = "0x8C7320", Offset = "0x8C6120", VA = "0x108C7320")]
    private void BackspaceForWin()
    {
    }

    [Token(Token = "0x600C489")]
    [Address(RVA = "0x8C8AD0", Offset = "0x8C78D0", VA = "0x108C8AD0")]
    private bool IsValidCharForWin(char c) => new bool();

    [Token(Token = "0x600C48A")]
    [Address(RVA = "0x8C89C0", Offset = "0x8C77C0", VA = "0x108C89C0")]
    private bool InPlaceEditingForWin() => new bool();

    [Token(Token = "0x600C48B")]
    [Address(RVA = "0x8C89D0", Offset = "0x8C77D0", VA = "0x108C89D0")]
    private void InsertForWin(char c)
    {
    }

    [Token(Token = "0x600C48C")]
    [Address(RVA = "0x8C6A20", Offset = "0x8C5820", VA = "0x108C6A20", Slot = "67")]
    protected override void Append(char input)
    {
    }

    [Token(Token = "0x600C48D")]
    [Address(RVA = "0x8C8B30", Offset = "0x8C7930", VA = "0x108C8B30")]
    protected InputField.EditState KeyPressedForWin(UnityEngine.Event evt)
    {
      return new InputField.EditState();
    }

    [Token(Token = "0x600C48E")]
    [Address(RVA = "0x8CA060", Offset = "0x8C8E60", VA = "0x108CA060", Slot = "68")]
    public override void Rebuild(CanvasUpdate update)
    {
    }

    [Token(Token = "0x600C48F")]
    [Address(RVA = "0x8CA120", Offset = "0x8C8F20", VA = "0x108CA120")]
    private void UpdateGeometryForWin()
    {
    }

    [Token(Token = "0x600C490")]
    [Address(RVA = "0x8C6BA0", Offset = "0x8C59A0", VA = "0x108C6BA0")]
    private void AssignPositioningIfNeeded()
    {
    }

    [Token(Token = "0x600C491")]
    [Address(RVA = "0x8C9A50", Offset = "0x8C8850", VA = "0x108C9A50")]
    private void OnFillVBO(Mesh vbo)
    {
    }

    [Token(Token = "0x600C492")]
    [Address(RVA = "0x8C79E0", Offset = "0x8C67E0", VA = "0x108C79E0")]
    private void GenerateCaret(VertexHelper vbo, Vector2 roundingOffset)
    {
    }

    [Token(Token = "0x600C493")]
    [Address(RVA = "0x8C73E0", Offset = "0x8C61E0", VA = "0x108C73E0")]
    private void CreateCursorVerts()
    {
    }

    [Token(Token = "0x600C494")]
    [Address(RVA = "0x8C8160", Offset = "0x8C6F60", VA = "0x108C8160")]
    private void GenerateHightlight(VertexHelper vbo, Vector2 roundingOffset)
    {
    }

    [Token(Token = "0x600C495")]
    [Address(RVA = "0x8CA470", Offset = "0x8C9270", VA = "0x108CA470")]
    public SRPG_InputField()
    {
    }

    [Token(Token = "0x600C496")]
    [Address(RVA = "0x8CA3F0", Offset = "0x8C91F0", VA = "0x108CA3F0")]
    static SRPG_InputField()
    {
    }
  }
}
