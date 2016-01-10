/*
* Kendo UI Localization Project for v2012.3.1114 
* Copyright 2012 Telerik AD. All rights reserved.
* 
* English US (en-US) Language Pack
*
* Project home  : https://github.com/loudenvier/kendo-global
* Kendo UI home : http://kendoui.com
* Author        : Felipe Machado (Loudenvier) 
*                 http://feliperochamachado.com.br/index_en.html
*
* This project is released to the public domain, although one must abide to the 
* licensing terms set forth by Telerik to use Kendo UI, as shown bellow.
*
* Telerik's original licensing terms:
* -----------------------------------
* Kendo UI Web commercial licenses may be obtained at
* https://www.kendoui.com/purchase/license-agreement/kendo-ui-web-commercial.aspx
* If you do not own a commercial license, this file shall be governed by the
* GNU General Public License (GPL) version 3.
* For GPL requirements, please review: http://www.gnu.org/copyleft/gpl.html
*/

kendo.ui.Locale = "ไทย (th-TH)";
kendo.ui.ColumnMenu.prototype.options.messages =
  $.extend(kendo.ui.ColumnMenu.prototype.options.messages, {

      /* COLUMN MENU MESSAGES 
       ****************************************************************************/
      sortAscending: "เรียงลำดับจาก น้อยไปหามาก",
      sortDescending: "เรียงลำดับจาก มากไปหาน้อย",
      filter: "กรอง",
      columns: "คอลัม"
      /***************************************************************************/
  });

kendo.ui.Groupable.prototype.options.messages =
  $.extend(kendo.ui.Groupable.prototype.options.messages, {

      /* GRID GROUP PANEL MESSAGES 
       ****************************************************************************/
      empty: "Drag a column header and drop it here to group by that column"
      /***************************************************************************/
  });

kendo.ui.FilterMenu.prototype.options.messages =
  $.extend(kendo.ui.FilterMenu.prototype.options.messages, {

      /* FILTER MENU MESSAGES 
       ***************************************************************************/
      info: "แสดงค่าตามเงื่อนไข:", // sets the text on top of the filter menu
      isTrue: "จริง",                   // sets the text for "isTrue" radio button
      isFalse: "เท็จ",                 // sets the text for "isFalse" radio button
      filter: "กรอง",                    // sets the text for the "Filter" button
      clear: "ล้างค่า",                      // sets the text for the "Clear" button
      and: "และ",
      or: "หรือ",
      selectValue: "-เลือกค่า-"
      /***************************************************************************/
  });

kendo.ui.FilterMenu.prototype.options.operators =
  $.extend(kendo.ui.FilterMenu.prototype.options.operators, {

      /* FILTER MENU OPERATORS (for each supported data type) 
       ****************************************************************************/
      string: {
          eq: "เท่ากับ",
          neq: "ไม่เท่ากับ",
          startswith: "เริ่มต้นด้วย",
          contains: "มีค่านี้อยู่",
          doesnotcontain: "ไม่มีค่านี้อยู่",
          endswith: "ลงท้าย"
      },
      number: {
          eq: "เท่ากับ",
          neq: "ไม่เท่ากับ",
          gte: "มากกว่าหรือเท่ากับ",
          gt: "มากกว่า",
          lte: "น้อยกว่าหรือเท่ากับ",
          lt: "น้อยกว่า"
      },
      date: {
          eq: "เท่ากับ",
          neq: "ไม่เท่ากับ",
          gte: "หลังหรือเท่ากับวันที่นี้",
          gt: "หลัง",
          lte: "ก่อนหรือเท่ากับวันที่นี้",
          lt: "ก่อน"
      },
      enums: {
          eq: "เท่ากับ",
          neq: "ไม่เท่ากับ"
      }
      /***************************************************************************/
  });

kendo.ui.Pager.prototype.options.messages =
  $.extend(kendo.ui.Pager.prototype.options.messages, {

      /* PAGER MESSAGES 
       ****************************************************************************/
      display: "{0} - {1} จาก {2} รายการ",
      empty: "ไม่มีค่าแสดง",
      page: "หน้า",
      of: "จาก {0}",
      itemsPerPage: "รายการต่อหน้า",
      first: "ไปหน้าแรก",
      previous: "ไปหน้าก่อนหน้านี้",
      next: "ไปหน้าถัดไป",
      last: "ไปหน้าสุดท้าย",
      refresh: "ปรับปรุง"
      /***************************************************************************/
  });

kendo.ui.Validator.prototype.options.messages =
  $.extend(kendo.ui.Validator.prototype.options.messages, {

      /* VALIDATOR MESSAGES 
       ****************************************************************************/
      required: "{0} is required",
      pattern: "{0} is not valid",
      min: "{0} should be greater than or equal to {1}",
      max: "{0} should be smaller than or equal to {1}",
      step: "{0} is not valid",
      email: "{0} is not valid email",
      url: "{0} is not valid URL",
      date: "{0} is not valid date"
      /***************************************************************************/
  });

kendo.ui.ImageBrowser.prototype.options.messages =
  $.extend(kendo.ui.ImageBrowser.prototype.options.messages, {

      /* IMAGE BROWSER MESSAGES 
       ****************************************************************************/
      uploadFile: "Upload",
      orderBy: "Arrange by",
      orderByName: "Name",
      orderBySize: "Size",
      directoryNotFound: "A directory with this name was not found.",
      emptyFolder: "Empty Folder",
      deleteFile: 'Are you sure you want to delete "{0}"?',
      invalidFileType: "The selected file \"{0}\" is not valid. Supported file types are {1}.",
      overwriteFile: "A file with name \"{0}\" already exists in the current directory. Do you want to overwrite it?",
      dropFilesHere: "drop files here to upload"
      /***************************************************************************/
  });

kendo.ui.Editor.prototype.options.messages =
  $.extend(kendo.ui.Editor.prototype.options.messages, {

      /* EDITOR MESSAGES 
       ****************************************************************************/
      bold: "Bold",
      italic: "Italic",
      underline: "Underline",
      strikethrough: "Strikethrough",
      superscript: "Superscript",
      subscript: "Subscript",
      justifyCenter: "Center text",
      justifyLeft: "Align text left",
      justifyRight: "Align text right",
      justifyFull: "Justify",
      insertUnorderedList: "Insert unordered list",
      insertOrderedList: "Insert ordered list",
      indent: "Indent",
      outdent: "Outdent",
      createLink: "Insert hyperlink",
      unlink: "Remove hyperlink",
      insertImage: "Insert image",
      insertHtml: "Insert HTML",
      fontName: "Select font family",
      fontNameInherit: "(inherited font)",
      fontSize: "Select font size",
      fontSizeInherit: "(inherited size)",
      formatBlock: "Format",
      foreColor: "Color",
      backColor: "Background color",
      style: "Styles",
      emptyFolder: "Empty Folder",
      uploadFile: "Upload",
      orderBy: "Arrange by:",
      orderBySize: "Size",
      orderByName: "Name",
      invalidFileType: "The selected file \"{0}\" is not valid. Supported file types are {1}.",
      deleteFile: 'Are you sure you want to delete "{0}"?',
      overwriteFile: 'A file with name "{0}" already exists in the current directory. Do you want to overwrite it?',
      directoryNotFound: "A directory with this name was not found.",
      imageWebAddress: "Web address",
      imageAltText: "Alternate text",
      dialogInsert: "Insert",
      dialogButtonSeparator: "or",
      dialogCancel: "Cancel"
      /***************************************************************************/
  });