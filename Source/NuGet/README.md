# TitleBarWF

This small library is a fully customizable WinForms title bar control designed for applications that use **FormBorderStyle.None** and need complete control over the form's chrome, layout, and behavior. TitleBarWF replicates the familiar Windows title bar experiences, like icon, title text, and minimize/maximize/restore/close buttons, while giving developers the freedom to style, extend, or replace any part of it.

This library is ideal for modern, themed, or branded WinForms applications where the default system title bar is far too limiting.

---

## Why TitleBarWF?

WinForms provides a simple way to remove the system title bar by making the following setting.

```csharp
form.FormBorderStyle = FormBorderStyle.None;

```

However, once you do that, you lose all of the following capabilities.

-   Window dragging.
-   Double‑click maximize.
-   System buttons.
-   Window icon.
-   Title text.
-   Hit‑testing for resizing.

TitleBarWF solves these problems by giving you a drop‑in control that restores all the expected window behaviors while letting you customize the entire UI including the title bar.

---

## Key Features

The following are some of the most noticeable traits of this control.

---

### Customizable UI

-   Replace the icon, title text, or buttons.
-   Apply your own colors, fonts, and styles.
-   Add additional controls (search boxes, menus, custom buttons, etc.).
-   Use the entire title bar area as a layout surface.

---

### Full Window Control

-   Drag the window from any non-interactive area.
-   Double‑click to maximize/restore.
-   Minimize, maximize, restore, and close buttons included.
-   Optional hit‑testing support for resizing (if you choose to implement it).

---

### Developer-Friendly

-   Simple API.
-   Works with any WinForms project.
-   No external dependencies.
-   Behaves like a standard control. Just drop it on your form and go.

---

## Getting Started

Follow these steps to get started with TitleBarWF.

---

### 1. Install

You can attach the library to your application directly from NuGet.

If you prefer to work with the source project, you can clone or download the repository from GitHub using the following command, then either add the project to your solution or reference the compiled assembly.

```bash
git clone https://github.com/danielanywhere/TitleBarWF.git

```

---

### 2. Configure Your Form

Set your form to borderless.

```csharp
this.FormBorderStyle = FormBorderStyle.None;

```

---

### 3. Add the Control

Drag **TitleBarWF** onto your form (or create it in code using the following example).

```csharp
var titleBar = new TitleBarWF();
titleBar.Dock = DockStyle.Top;
this.Controls.Add(titleBar);

```

---

### 4. Customize (Optional)

```csharp
titleBar.TitleText = "My Application";
titleBar.Icon = Properties.Resources.MyIcon;
titleBar.BackColor = Color.FromArgb(30, 30, 30);
titleBar.ForeColor = Color.White;

```

You can also add your own controls.

```csharp
titleBar.Controls.Add(new Button { Text = "Help" });

```

---

## How It Works

TitleBarWF handles all of the following.

-   Mouse hit‑testing for dragging.
-   Button click events for window actions.
-   State changes (maximize/restore) .
-   Rendering of icon and title.
-   Layout of built‑in buttons.

You can override or extend any of these behaviors.

---

## Example

For an example of TitleBarWF in action, please see the GitHub repository [danielanywhere/CaptionAll](https://github.com/danielanywhere/CaptionAll).

---

## License

This project is licensed under the **AGPL‑3.0** license.

See the \`LICENSE\` file for details.

---

## Contributing

Contributions are welcome!

Feel free to open issues, submit pull requests, or suggest enhancements.

---

## Future Enhancements

Potential improvements might include any of the following.

-   Built‑in resizing borders.
-   Dark/light theme presets.
-   Fluent/WinUI‑style button animations.
-   High‑DPI icon scaling.
-   Optional system menu support.

If any of these interest you, join the discussion in the Issues section.


## Updates

| Version | Description |
|---------|-------------|
| 26.2130.4508 | Initial publication to NuGet. |


## More Information

For more information, please see the GitHub project:
[danielanywhere/TitleBarWF](https://github.com/danielanywhere/TitleBarWF)

Full API documentation is available at this library's [GitHub User Page](https://danielanywhere.github.io/TitleBarWF).

