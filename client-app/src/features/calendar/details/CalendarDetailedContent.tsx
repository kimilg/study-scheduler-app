import { observer } from "mobx-react-lite";
import React from "react";
import { Divider, Grid, List, Segment } from "semantic-ui-react";
import { Work } from "../../../app/models/work";

interface Props {
    works: Work[] | null;
}
export default observer(function CalendarDetailedContent({ works }: Props) {
    return (
        <Segment>
            <Grid>
                <Grid.Column width={3}>
                    <h4>13:00 - 14:00</h4>
                </Grid.Column>
                <Grid.Column width={13}>
                    <List divided relaxed>
                        {works?.map(work => (
                            <List.Item key={work.id} style={{marginBottom: 10}}>
                                <List.Content>
                                    <List.Header>{work.title}</List.Header>
                                    <List.Description>{work.description}</List.Description>
                                </List.Content>
                            </List.Item>
                        ))}
                    </List>
                </Grid.Column>
            </Grid>
        </Segment>
    )
})