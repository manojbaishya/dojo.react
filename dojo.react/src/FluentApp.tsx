import {
    FluentProvider,
    webLightTheme,
    Button
} from "@fluentui/react-components";

export default function FluentApp() {
    return (
        <FluentProvider theme={webLightTheme}>
            <Button appearance="primary">Hello Fluent UI React</Button>
        </FluentProvider>
    );
}