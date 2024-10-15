// Decompiled with JetBrains decompiler
// Type: SRPG.CharLimitFormat
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x2002150")]
  [AddComponentMenu("UI/CharLimitFormat")]
  public class CharLimitFormat : MonoBehaviour
  {
    [Token(Token = "0x4009123")]
    [FieldOffset(Offset = "0xC")]
    private readonly string SEPARATOR_STRING;
    [Token(Token = "0x4009124")]
    [FieldOffset(Offset = "0x10")]
    [SerializeField]
    private bool display_brackets;
    [Token(Token = "0x4009125")]
    [FieldOffset(Offset = "0x11")]
    [SerializeField]
    private bool force_override_limit;
    [Token(Token = "0x4009126")]
    [FieldOffset(Offset = "0x14")]
    [SerializeField]
    private int force_override_limit_value;
    [Token(Token = "0x4009127")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    private bool append_char_type;
    [Token(Token = "0x4009128")]
    [FieldOffset(Offset = "0x1C")]
    [SerializeField]
    private CharLimitFormat.EditType edit_type;
    [Token(Token = "0x4009129")]
    [FieldOffset(Offset = "0x20")]
    [SerializeField]
    private CharLimitFormat.FormatType format_type;
    [Token(Token = "0x400912A")]
    [FieldOffset(Offset = "0x24")]
    [SerializeField]
    private InputField input_field;
    [Token(Token = "0x400912B")]
    [FieldOffset(Offset = "0x28")]
    [SerializeField]
    private bool check_update;
    [Token(Token = "0x400912C")]
    [FieldOffset(Offset = "0x29")]
    private bool is_finish_edit;
    [Token(Token = "0x400912D")]
    [FieldOffset(Offset = "0x2C")]
    private Text text;

    [Token(Token = "0x6008BE9")]
    [Address(RVA = "0x4F5700", Offset = "0x4F4500", VA = "0x104F5700")]
    private void Awake()
    {
    }

    [Token(Token = "0x6008BEA")]
    [Address(RVA = "0x4F5E60", Offset = "0x4F4C60", VA = "0x104F5E60")]
    private void Update()
    {
    }

    [Token(Token = "0x6008BEB")]
    [Address(RVA = "0x4F5760", Offset = "0x4F4560", VA = "0x104F5760")]
    private void EditForUpdate()
    {
    }

    [Token(Token = "0x6008BEC")]
    [Address(RVA = "0x4F57E0", Offset = "0x4F45E0", VA = "0x104F57E0")]
    private void Edit()
    {
    }

    [Token(Token = "0x6008BED")]
    [Address(RVA = "0x4F5D40", Offset = "0x4F4B40", VA = "0x104F5D40")]
    private string GetStringFormat(CharLimitFormat.FormatType _format_type) => (string) null;

    [Token(Token = "0x6008BEE")]
    [Address(RVA = "0x4F5BB0", Offset = "0x4F49B0", VA = "0x104F5BB0")]
    private string GetCharTypeText(InputField _input_field) => (string) null;

    [Token(Token = "0x6008BEF")]
    [Address(RVA = "0x4F5AE0", Offset = "0x4F48E0", VA = "0x104F5AE0")]
    private string GetCharTypeTextByTypeCustom(InputField _input_field) => (string) null;

    [Token(Token = "0x6008BF0")]
    [Address(RVA = "0x4F5EE0", Offset = "0x4F4CE0", VA = "0x104F5EE0")]
    public CharLimitFormat()
    {
    }

    [Token(Token = "0x2002151")]
    private enum EditType
    {
      [Token(Token = "0x400912F")] Append,
      [Token(Token = "0x4009130")] Replace,
    }

    [Token(Token = "0x2002152")]
    private enum FormatType
    {
      [Token(Token = "0x4009132")] Simple,
      [Token(Token = "0x4009133")] Append_Saidai,
      [Token(Token = "0x4009134")] Append_Inai,
      [Token(Token = "0x4009135")] Navi_Saidai,
    }
  }
}
