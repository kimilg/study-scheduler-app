import React from "react";
import { Header, Item, Segment } from "semantic-ui-react";

export default function CalendarDetailedHeader(){
    return (
        <Segment.Group>
            <Segment textAlign='center'>
                <Item.Group>
                    <Item>
                        <Item.Content>
                            <Header
                                size='huge'
                                content='Today Schedule'
                            />
                        </Item.Content>
                    </Item>
                </Item.Group>
            </Segment>
        </Segment.Group>    
    )
}